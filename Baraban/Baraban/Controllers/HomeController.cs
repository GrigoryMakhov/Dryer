using Baraban.Models;
using MathLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Baraban.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataInputAdd()
        {
            DataInputModel _m = DataInputModel.GetDefaultModel();

            #region --- Задать исходные данные для первого найденного варианта

            

            #endregion --- Задать исходные данные для первого найденного варианта

            ViewBag.DataInput = _m;

            return View();
        }

        [HttpPost]
        public IActionResult DataInputAdd(DataInputModel DataInput)
        {
            if (DataInput == null) return BadRequest();
            UserModel user = _context.Users.FirstOrDefault(x => x.Login == User.Identity.Name);
            if (user == null) return BadRequest();
            DataInput.UserId = user.Id;
            
            

            _context.DataInputs.Add(DataInput); 
            _context.SaveChanges();
            return RedirectToAction("Raschet");

        }
        
        [HttpGet]
        public IActionResult Raschet()
        {
            UserModel user = _context.Users.FirstOrDefault(x=>x.Login==User.Identity.Name);
            return View(_context.DataInputs.Where(x=>x.UserId == user.Id || x.UserId == 0));  

        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            DataInputModel dataInput = _context.DataInputs.Find(id);
            if (dataInput == null) return NotFound();
            _context.DataInputs.Remove(dataInput);
            _context.SaveChanges();
            return RedirectToAction("Raschet");

        }

        public IActionResult DataInputEdit(int id)
        {
           DataInputModel dataInput = _context.DataInputs.Find(id);
           if (dataInput == null) return NotFound();
           return View(dataInput);  
        }

        [HttpPost]
        public IActionResult DataInputEdit(DataInputModel DataInput)
        {
            if (DataInput == null) return RedirectToAction(nameof(Index));

            var existData = _context.DataInputs.AsNoTracking().FirstOrDefault(x => x.Id == DataInput.Id);

            if (existData == null) return RedirectToAction(nameof(Index));

            if(existData.Name != DataInput.Name)
            {
                DataInput.Id = 0;
                _context.DataInputs.Add(DataInput);
            }
            else
            {
                _context.DataInputs.Update(DataInput);
            }
            _context.SaveChanges();
            
            return RedirectToAction("Raschet");
        }

        [HttpGet]
        public IActionResult Calc(int id)
        {
            DataInputModel dataInput = _context.DataInputs.FirstOrDefault(x => x.Id == id);
            if (dataInput == null) return NotFound();
            DataOutputModel _rezult = new DataOutputModel(dataInput);

            #region --- Вернуть на въюшку промежуточные результаты расчетов

            ViewBag.Cair = _rezult.Cair;
            ViewBag.enthalpyWater = _rezult.enthalpyWater;
            ViewBag.Csteam = _rezult.Csteam;
            ViewBag.exitCO2 = _rezult.exitCO2;
            ViewBag.exitSO2 = _rezult.exitSO2;
            ViewBag.exitH2O = _rezult.exitH2O;
            ViewBag.consumptionO2 = _rezult.consumptionO2;
            ViewBag.exitN2 = _rezult.exitN2;
            ViewBag.realexitN2 = _rezult.realexitN2;
            ViewBag.overageO2 = _rezult.overageO2;
            ViewBag.theoryСonsAir = _rezult.theoryСonsAir;
            ViewBag.realConsDryAir = _rezult.realConsDryAir;
            ViewBag.exitCombusProd = _rezult.exitCombusProd;
            ViewBag.Qfuel = _rezult.Qfuel;
            ViewBag.percentAir = _rezult.percentAir;
            ViewBag.balanceEntCombusProd = _rezult.balanceEntCombusProd;
            ViewBag.balanceTempCombusProd = _rezult.balanceTempCombusProd;
            ViewBag.enthalpyTorch = _rezult.enthalpyTorch;
            ViewBag.enthalpyAir = _rezult.enthalpyAir;
            ViewBag.enthalpyCombusProd = _rezult.enthalpyCombusProd;
            ViewBag.enthalpyFlueGases = _rezult.enthalpyFlueGases;
            ViewBag.airAmount = _rezult.airAmount;
            ViewBag.enthalpyAir100 = _rezult.enthalpyAir100;
            ViewBag.middleTempEnd = _rezult.middleTempEnd;
            ViewBag.startTempWall = _rezult.startTempWall;
            ViewBag.endTempWall = _rezult.endTempWall;
            ViewBag.middleTempWall = _rezult.middleTempWall;
            ViewBag.alphaHeatTrans = _rezult.alphaHeatTrans;
            ViewBag.startMaterialWet = _rezult.startMaterialWet;
            ViewBag.endMaterialWet = _rezult.endMaterialWet;
            ViewBag.WetEfficiency = _rezult.WetEfficiency;
            ViewBag.Q2B = _rezult.Q2B;
            ViewBag.Q3B = _rezult.Q3B;
            ViewBag.Q5tpoB = _rezult.Q5tpoB;

            #endregion --- Вернуть на въюшку промежуточные результаты расчетов

            #region --- Вернуть на въюшку итоговые результаты расчетов

            ViewBag.Q1 = _rezult.Q1;
            ViewBag.Q5t = _rezult.Q5t;
            ViewBag.B = _rezult.B;
            ViewBag.Qh = _rezult.Qh;
            ViewBag.qevapor = _rezult.qevapor;
            ViewBag.Q2 = _rezult.Q2;
            ViewBag.Q3 = _rezult.Q3;
            ViewBag.Q5top = _rezult.Q5top;
            ViewBag.percentQ1 = _rezult.percentQ1;
            ViewBag.percentQ2 = _rezult.percentQ2;
            ViewBag.percentQ3 = _rezult.percentQ3;
            ViewBag.percentQ5top = _rezult.percentQ5top;
            ViewBag.percentQ5t = _rezult.percentQ5t;

            #endregion --- Вернуть на въюшку итоговые результаты расчетов

            #region --- Лист для круговой диаграммы

            var lists = new List<double>()
            {

               _rezult.Q1,
               _rezult.Q2,
               _rezult.Q3,
               _rezult.Q5t,
               _rezult.Q5top,

            };
            ViewBag.lists = Newtonsoft.Json.JsonConvert.SerializeObject(lists);

            #endregion --- Лист для круговой диаграммы

            ViewBag.inputId = dataInput.Id;

            return View("Rezult");
        }


        [HttpGet]
        public IActionResult Report(int id)
        {
            DataInputModel dataInput = _context.DataInputs.Find(id);
            if (dataInput == null) return NotFound();
            DataOutputModel _rezult = new DataOutputModel(dataInput);

            #region Исходные данные

            ViewBag.Wstart = dataInput.Wstart; 
            ViewBag.Wend = dataInput.Wend;
            ViewBag.percentCp = dataInput.percentCp;
            ViewBag.percentHp = dataInput.percentHp;
            ViewBag.percentSp = dataInput.percentSp;
            ViewBag.percentOp = dataInput.percentOp;
            ViewBag.percentNp = dataInput.percentNp;
            ViewBag.percentAp = dataInput.percentAp;
            ViewBag.percentWp = dataInput.percentWp;
            ViewBag.t1 = dataInput.t1;
            ViewBag.t2 = dataInput.t2;
            ViewBag.alpha = dataInput.alpha;
            ViewBag.eta = dataInput.eta;
            ViewBag.tair = dataInput.tair;
            ViewBag.tgase = dataInput.tgase;
            ViewBag.tm1 = dataInput.tm1;
            ViewBag.Gt = dataInput.Gt;
            ViewBag.Him = dataInput.Him;
            ViewBag.k = dataInput.k;
            ViewBag.Cgase = dataInput.Cgase;
            ViewBag.Cmaterial = dataInput.Cmaterial;
            ViewBag.Cwet = dataInput.Cwet;
            ViewBag.enthalpy100 = dataInput.enthalpy100;
            ViewBag.D = dataInput.D;
            ViewBag.L = dataInput.L;

            #endregion 

            #region --- Вернуть на въюшку промежуточные результаты расчетов

            ViewBag.Cair = _rezult.Cair;
            ViewBag.enthalpyWater = _rezult.enthalpyWater;
            ViewBag.Csteam = _rezult.Csteam;
            ViewBag.exitCO2 = _rezult.exitCO2;
            ViewBag.exitSO2 = _rezult.exitSO2;
            ViewBag.exitH2O = _rezult.exitH2O;
            ViewBag.consumptionO2 = _rezult.consumptionO2;
            ViewBag.exitN2 = _rezult.exitN2;
            ViewBag.realexitN2 = _rezult.realexitN2;
            ViewBag.overageO2 = _rezult.overageO2;
            ViewBag.theoryСonsAir = _rezult.theoryСonsAir;
            ViewBag.realConsDryAir = _rezult.realConsDryAir;
            ViewBag.exitCombusProd = _rezult.exitCombusProd;
            ViewBag.Qfuel = _rezult.Qfuel;
            ViewBag.percentAir = _rezult.percentAir;
            ViewBag.balanceEntCombusProd = _rezult.balanceEntCombusProd;
            ViewBag.balanceTempCombusProd = _rezult.balanceTempCombusProd;
            ViewBag.enthalpyTorch = _rezult.enthalpyTorch;
            ViewBag.enthalpyAir = _rezult.enthalpyAir;
            ViewBag.enthalpyCombusProd = _rezult.enthalpyCombusProd;
            ViewBag.enthalpyFlueGases = _rezult.enthalpyFlueGases;
            ViewBag.airAmount = _rezult.airAmount;
            ViewBag.enthalpyAir100 = _rezult.enthalpyAir100;
            ViewBag.middleTempEnd = _rezult.middleTempEnd;
            ViewBag.startTempWall = _rezult.startTempWall;
            ViewBag.endTempWall = _rezult.endTempWall;
            ViewBag.middleTempWall = _rezult.middleTempWall;
            ViewBag.alphaHeatTrans = _rezult.alphaHeatTrans;
            ViewBag.startMaterialWet = _rezult.startMaterialWet;
            ViewBag.endMaterialWet = _rezult.endMaterialWet;
            ViewBag.WetEfficiency = _rezult.WetEfficiency;
            ViewBag.Q2B = _rezult.Q2B;
            ViewBag.Q3B = _rezult.Q3B;
            ViewBag.Q5tpoB = _rezult.Q5tpoB;

            #endregion --- Вернуть на въюшку промежуточные результаты расчетов

            #region --- Вернуть на въюшку итоговые результаты расчетов

            ViewBag.Q1 = _rezult.Q1;
            ViewBag.Q5t = _rezult.Q5t;
            ViewBag.B = _rezult.B;
            ViewBag.Qh = _rezult.Qh;
            ViewBag.qevapor = _rezult.qevapor;
            ViewBag.Q2 = _rezult.Q2;
            ViewBag.Q3 = _rezult.Q3;
            ViewBag.Q5top = _rezult.Q5top;
            ViewBag.percentQ1 = _rezult.percentQ1;
            ViewBag.percentQ2 = _rezult.percentQ2;
            ViewBag.percentQ3 = _rezult.percentQ3;
            ViewBag.percentQ5top = _rezult.percentQ5top;
            ViewBag.percentQ5t = _rezult.percentQ5t;

            #endregion --- Вернуть на въюшку итоговые результаты расчетов

            #region --- Лист для круговой диаграммы

            var lists = new List<double>()
            {

               _rezult.Q1,
               _rezult.Q2,
               _rezult.Q3,
               _rezult.Q5t,
               _rezult.Q5top,

            };
            ViewBag.lists = Newtonsoft.Json.JsonConvert.SerializeObject(lists);

            #endregion --- Лист для круговой диаграммы


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
