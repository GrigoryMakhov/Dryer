using NUnit.Framework;
using MathLib;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System;

namespace TestProjectDemo
{
    public class Tests
    {
        private string fileName = "3 Сушильный барабан.xlsm";
        Excel.Application objExcel = null;
        Excel.Workbook WorkBook = null;

        private object oMissing = System.Reflection.Missing.Value;

        /// <summary>
        /// Метод тестирования математической библиотеки
        /// </summary>
        [Test]
        public void CalculationTest()
        {
            MathLibrary _ml = new MathLibrary();

            #region 1. Присвоить исходные данные 

            _ml.Wstart = 10.000;
            _ml.Wend = 0.500;
            _ml.percentCp = 86.600;
            _ml.percentHp = 10.400;
            _ml.percentSp = 0.900;
            _ml.percentOp = 0.400;
            _ml.percentNp = 0.600;
            _ml.percentAp = 0.300;
            _ml.percentWp = 0.800;
            _ml.t1 = 850.000;
            _ml.t2 = 460.000;
            _ml.alpha = 1.2;
            _ml.eta = 0.9;
            _ml.tair = 20.000;
            _ml.tgase = 20.000;
            _ml.tm1 = 40.000;
            _ml.Gt = 1.750;
            _ml.Him = 0.020;
            _ml.k = 3.760;
            _ml.Cgase = 0.835;
            _ml.Cmaterial = 0.880;
            _ml.Cwet = 4.190;
            _ml.enthalpy100 = 2675.000;
            _ml.D = 1.000;
            _ml.L = 4.000;

            #endregion 1. Присвоить исходные данные

            try
            {
                #region 2. Передать исходные данные в Excel-файл, записать в соответствующие ячейки

                objExcel = new Excel.Application();
                WorkBook = objExcel.Workbooks.Open(
                            Directory.GetCurrentDirectory() + "\\" + fileName);
                Excel.Worksheet WorkSheet = (Excel.Worksheet)WorkBook.Sheets["Расчёт"];

                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[1, 2]).Value2 = _ml.Wstart;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[2, 2]).Value2 = _ml.Wend;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[3, 2]).Value2 = _ml.percentCp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[4, 2]).Value2 = _ml.percentHp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[5, 2]).Value2 = _ml.percentSp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[6, 2]).Value2 = _ml.percentOp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[7, 2]).Value2 = _ml.percentNp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[8, 2]).Value2 = _ml.percentAp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[9, 2]).Value2 = _ml.percentWp;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[10, 2]).Value2 = _ml.t1;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[11, 2]).Value2 = _ml.t2;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[12, 2]).Value2 = _ml.alpha;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[13, 2]).Value2 = _ml.eta;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[14, 2]).Value2 = _ml.tair;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[15, 2]).Value2 = _ml.tgase;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[16, 2]).Value2 = _ml.tm1;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[17, 2]).Value2 = _ml.Gt;

                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[19, 2]).Value2 = _ml.Him;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[20, 2]).Value2 = _ml.k;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[21, 2]).Value2 = _ml.Cgase;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[22, 2]).Value2 = _ml.Cmaterial;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[23, 2]).Value2 = _ml.Cwet;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[24, 2]).Value2 = _ml.enthalpy100;

                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[21, 6]).Value2 = _ml.D;
                ((Microsoft.Office.Interop.Excel.Range)WorkSheet.Cells[22, 6]).Value2 = _ml.L;

                // отобразить в журнале тестирования
                Console.WriteLine("--- Исходные данные");
                Console.WriteLine("Число 1: {0}", _ml.Wstart.ToString());
                Console.WriteLine("Число 2: {0}", _ml.Wend.ToString());
                Console.WriteLine("Число 3: {0}", _ml.percentCp.ToString());
                Console.WriteLine("Число 4: {0}", _ml.percentHp.ToString());
                Console.WriteLine("Число 5: {0}", _ml.percentSp.ToString());
                Console.WriteLine("Число 6: {0}", _ml.percentOp.ToString());
                Console.WriteLine("Число 7: {0}", _ml.percentNp.ToString());
                Console.WriteLine("Число 8: {0}", _ml.percentAp.ToString());
                Console.WriteLine("Число 9: {0}", _ml.percentWp.ToString());
                Console.WriteLine("Число 10: {0}", _ml.t1.ToString());
                Console.WriteLine("Число 11: {0}", _ml.t2.ToString());
                Console.WriteLine("Число 12: {0}", _ml.alpha.ToString());
                Console.WriteLine("Число 13: {0}", _ml.eta.ToString());
                Console.WriteLine("Число 14: {0}", _ml.tair.ToString());
                Console.WriteLine("Число 15: {0}", _ml.tgase.ToString());
                Console.WriteLine("Число 16: {0}", _ml.tm1.ToString());
                Console.WriteLine("Число 17: {0}", _ml.Gt.ToString());
                Console.WriteLine("Число 18: {0}", _ml.Him.ToString());
                Console.WriteLine("Число 19: {0}", _ml.k.ToString());
                Console.WriteLine("Число 20: {0}", _ml.Cgase.ToString());
                Console.WriteLine("Число 21: {0}", _ml.Cmaterial.ToString());
                Console.WriteLine("Число 22: {0}", _ml.Cwet.ToString());
                Console.WriteLine("Число 23: {0}", _ml.enthalpy100.ToString());
                Console.WriteLine("Число 24: {0}", _ml.D.ToString());
                Console.WriteLine("Число 25: {0}", _ml.L.ToString());

                #endregion 2. Передать исходные данные в Excel-файл, записать в соответствующие ячейки

                #region 3. Прочитать из ячейки Excel-файла значение промежуточных Расчётных величин

                double Cair = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[26, 2]).Value.ToString());
                double enthalpyWater = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[27, 2]).Value.ToString());
                double Csteam = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[28, 2]).Value.ToString());
                double exitCO2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[40, 2]).Value.ToString());
                double exitSO2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[41, 2]).Value.ToString());
                double exitH2O = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[42, 2]).Value.ToString());
                double consumptionO2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[1, 6]).Value.ToString());
                double exitN2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[43, 2]).Value.ToString());
                double realexitN2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[44, 2]).Value.ToString());
                double overageO2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[45, 2]).Value.ToString());
                double theoryСonsAir = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[2, 6]).Value.ToString());
                double realConsDryAir = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[3, 6]).Value.ToString());
                double exitCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[4, 6]).Value.ToString());
                double Qfuel = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[5, 6]).Value.ToString());
                double percentAir = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[6, 6]).Value.ToString());
                double balanceEntCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[7, 6]).Value.ToString());
                double balanceTempCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[8, 6]).Value.ToString());
                double enthalpyTorch = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[9, 6]).Value.ToString());
                double enthalpyAir = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[10, 6]).Value.ToString());
                double enthalpyCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[11, 6]).Value.ToString());
                double enthalpyFlueGases = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[12, 6]).Value.ToString());
                double airAmount = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[13, 6]).Value.ToString());
                double enthalpyAir100 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[14, 6]).Value.ToString());
                double middleTempEnd = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[15, 6]).Value.ToString());
                double startTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[33, 6]).Value.ToString());
                double endTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[34, 6]).Value.ToString());
                double middleTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[32, 6]).Value.ToString());
                double alphaHeatTrans = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[35, 6]).Value.ToString());
                double startMaterialWet = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[38, 6]).Value.ToString());
                double endMaterialWet = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[39, 6]).Value.ToString());
                double WetEfficiency = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[36, 6]).Value.ToString());
                double Q2B = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[26, 6]).Value.ToString());
                double Q3B = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[27, 6]).Value.ToString());
                double Q5tpoB = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[29, 6]).Value.ToString());

                #endregion 3. Прочитать из ячейки Excel-файла значение промежуточных Расчётных величин

                #region  4. Прочитать из ячейки Excel-файла значение итоговых Расчётных величин

                double Q1 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[25, 6]).Value.ToString());
                double Q5t = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[30, 6]).Value.ToString());
                double B = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[44, 6]).Value.ToString());
                double Qh = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[46, 6]).Value.ToString());
                double qevapor = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[47, 6]).Value.ToString());
                double Q2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[26, 10]).Value.ToString());
                double Q3 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[27, 10]).Value.ToString());
                double Q5top = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[29, 10]).Value.ToString());
                double percentQ1 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[25, 11]).Value.ToString());
                double percentQ2 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[26, 11]).Value.ToString());
                double percentQ3 = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[27, 11]).Value.ToString());
                double percentQ5top = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[29, 11]).Value.ToString());
                double percentQ5t = double.Parse(((Excel.Range)WorkBook.Sheets["Расчёт"].Cells[30, 11]).Value.ToString());

                #endregion  4. Прочитать из ячейки Excel-файла значение итоговых Расчётных величин

                #region  5. Сравнить промежуточные значения из Excel и из библиотеки с заданной точностью

                Assert.AreEqual(Cair, Math.Round(_ml.Cair(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Удельная теплоемкость воздуха - Cair: expected =" +
                            Cair + "; actual=" + Math.Round(_ml.Cair(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Удельная теплоемкость воздуха, метод Cair(): expected = " +
                            Cair + "; actual=" + Math.Round(_ml.Cair(), 3));

                Assert.AreEqual(enthalpyWater, Math.Round(_ml.enthalpyWater(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Начальная энтальпия воды - enthalpyWater: expected =" +
                            enthalpyWater + "; actual=" + Math.Round(_ml.enthalpyWater(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Начальная энтальпия воды, метод enthalpyWater(): expected = " +
                            enthalpyWater + "; actual=" + Math.Round(_ml.enthalpyWater(), 3));

                Assert.AreEqual(Csteam, Math.Round(_ml.Csteam(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Удельная теплоемкость пара - Csteam: expected =" +
                            Csteam + "; actual=" + Math.Round(_ml.Csteam(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Удельная теплоемкость пара, метод Csteam(): expected = " +
                            Csteam + "; actual=" + Math.Round(_ml.Csteam(), 3));

                Assert.AreEqual(exitCO2, Math.Round(_ml.exitCO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Выход CO2 в продуктах горения - SSum: expected =" +
                            exitCO2 + "; actual=" + Math.Round(_ml.exitCO2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Выход CO2 в продуктах горения, метод exitCO2(): expected = " +
                            exitCO2 + "; actual=" + Math.Round(_ml.exitCO2(), 3));

                Assert.AreEqual(exitSO2, Math.Round(_ml.exitSO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Выход SO2 в продуктах горения - exitSO2: expected =" +
                            exitSO2 + "; actual=" + Math.Round(_ml.exitSO2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Выход SO2 в продуктах горения, метод exitSO2(): expected = " +
                            exitSO2 + "; actual=" + Math.Round(_ml.exitSO2(), 3));

                Assert.AreEqual(exitH2O, Math.Round(_ml.exitH2O(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Выход H2O в продуктах горения - exitH2O: expected =" +
                            exitH2O + "; actual=" + Math.Round(_ml.exitH2O(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Выход H2O в продуктах горения, метод exitH2O(): expected = " +
                            exitH2O + "; actual=" + Math.Round(_ml.exitH2O(), 3));

                Assert.AreEqual(consumptionO2, Math.Round(_ml.consumptionO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Расход кислорода на горение - consumptionO2: expected =" +
                            consumptionO2 + "; actual=" + Math.Round(_ml.consumptionO2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Расход кислорода на горение, метод consumptionO2(): expected = " +
                            consumptionO2 + "; actual=" + Math.Round(_ml.consumptionO2(), 3));

                Assert.AreEqual(exitN2, Math.Round(_ml.exitN2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Выход N2 в продуктах горения - exitN2: expected =" +
                            exitN2 + "; actual=" + Math.Round(_ml.exitN2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Выход N2 в продуктах горения, метод exitN2(): expected = " +
                            exitN2 + "; actual=" + Math.Round(_ml.exitN2(), 3));

                Assert.AreEqual(realexitN2, Math.Round(_ml.realexitN2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Действительный выход N2 в продуктах горения - realexitN2: expected =" +
                            realexitN2 + "; actual=" + Math.Round(_ml.realexitN2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Действительный выход N2 в продуктах горения, метод realexitN2(): expected = " +
                            realexitN2 + "; actual=" + Math.Round(_ml.realexitN2(), 3));

                Assert.AreEqual(overageO2, Math.Round(_ml.overageO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Избыточный объем кислорода - overageO2: expected =" +
                            overageO2 + "; actual=" + Math.Round(_ml.overageO2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Избыточный объем кислорода, метод overageO2(): expected = " +
                            overageO2 + "; actual=" + Math.Round(_ml.overageO2(), 3));

                Assert.AreEqual(theoryСonsAir, Math.Round(_ml.theoryСonsAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Теоретический расход воздуха - theoryСonsAir: expected =" +
                            theoryСonsAir + "; actual=" + Math.Round(_ml.theoryСonsAir(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Теоретический расход воздуха, метод theoryСonsAir(): expected = " +
                            theoryСonsAir + "; actual=" + Math.Round(_ml.theoryСonsAir(), 3));

                Assert.AreEqual(realConsDryAir, Math.Round(_ml.realConsDryAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Действительный расход сухого воздуха - realConsDryAir: expected =" +
                            realConsDryAir + "; actual=" + Math.Round(_ml.realConsDryAir(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Действительный расход сухого воздуха, метод realConsDryAir(): expected = " +
                            realConsDryAir + "; actual=" + Math.Round(_ml.realConsDryAir(), 3));

                Assert.AreEqual(exitCombusProd, Math.Round(_ml.exitCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Выход продуктов горения - exitCombusProd: expected =" +
                            exitCombusProd + "; actual=" + Math.Round(_ml.exitCombusProd(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Выход продуктов горения, метод exitCombusProd(): expected = " +
                            exitCombusProd + "; actual=" + Math.Round(_ml.exitCombusProd(), 3));

                Assert.AreEqual(Qfuel, Math.Round(_ml.Qfuel(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Теплота сгорания мазута - Qfuel: expected =" +
                            Qfuel + "; actual=" + Math.Round(_ml.Qfuel(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Теплота сгорания мазута, метод Qfuel(): expected = " +
                            Qfuel + "; actual=" + Math.Round(_ml.Qfuel(), 3));

                Assert.AreEqual(percentAir, Math.Round(_ml.percentAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Содержание воздуха в продуктах сгорания - percentAir: expected =" +
                            percentAir + "; actual=" + Math.Round(_ml.percentAir(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Содержание воздуха в продуктах сгорания, метод percentAir(): expected = " +
                            percentAir + "; actual=" + Math.Round(_ml.percentAir(), 3));

                Assert.AreEqual(balanceEntCombusProd, Math.Round(_ml.balanceEntCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Балансовая энтальпия продуктов горения - balanceEntCombusProd: expected =" +
                            balanceEntCombusProd + "; actual=" + Math.Round(_ml.balanceEntCombusProd(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Балансовая энтальпия продуктов горения, метод balanceEntCombusProd(): expected = " +
                            balanceEntCombusProd + "; actual=" + Math.Round(_ml.balanceEntCombusProd(), 3));

                Assert.AreEqual(balanceTempCombusProd, Math.Round(_ml.balanceTempCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Балансовая температура продуктов горения - balanceTempCombusProd: expected =" +
                            balanceTempCombusProd + "; actual=" + Math.Round(_ml.balanceTempCombusProd(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Балансовая температура продуктов горения, метод balanceTempCombusProd(): expected = " +
                            balanceTempCombusProd + "; actual=" + Math.Round(_ml.balanceTempCombusProd(), 3));

                Assert.AreEqual(enthalpyTorch, Math.Round(_ml.enthalpyTorch(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Энтальпия факела - enthalpyTorch: expected =" +
                            enthalpyTorch + "; actual=" + Math.Round(_ml.enthalpyTorch(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Энтальпия факела, метод enthalpyTorch(): expected = " +
                            enthalpyTorch + "; actual=" + Math.Round(_ml.enthalpyTorch(), 3));

                Assert.AreEqual(enthalpyAir, Math.Round(_ml.enthalpyAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Энтальпия воздуха - enthalpyAir: expected =" +
                            enthalpyAir + "; actual=" + Math.Round(_ml.enthalpyAir(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Энтальпия воздуха, метод enthalpyAir(): expected = " +
                            enthalpyAir + "; actual=" + Math.Round(_ml.enthalpyAir(), 3));

                Assert.AreEqual(enthalpyCombusProd, Math.Round(_ml.enthalpyCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Энтальпия продуктов сгорания - enthalpyCombusProd: expected =" +
                            enthalpyCombusProd + "; actual=" + Math.Round(_ml.enthalpyCombusProd(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Энтальпия продуктов сгорания, метод enthalpyCombusProd(): expected = " +
                            enthalpyCombusProd + "; actual=" + Math.Round(_ml.enthalpyCombusProd(), 3));

                Assert.AreEqual(enthalpyFlueGases, Math.Round(_ml.enthalpyFlueGases(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Энтальпия дымовых газов - enthalpyFlueGases: expected =" +
                            enthalpyFlueGases + "; actual=" + Math.Round(_ml.enthalpyFlueGases(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Энтальпия дымовых газов, метод enthalpyFlueGases(): expected = " +
                            enthalpyFlueGases + "; actual=" + Math.Round(_ml.enthalpyFlueGases(), 3));

                Assert.AreEqual(airAmount, Math.Round(_ml.airAmount(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Количество воздуха - airAmount: expected =" +
                            airAmount + "; actual=" + Math.Round(_ml.airAmount(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Количество воздуха, метод airAmount(): expected = " +
                            airAmount + "; actual=" + Math.Round(_ml.airAmount(), 3));

                Assert.AreEqual(enthalpyAir100, Math.Round(_ml.enthalpyAir100(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Энтальпия воздуха при t2 и VL = 100% - enthalpyAir100: expected =" +
                            enthalpyAir100 + "; actual=" + Math.Round(_ml.enthalpyAir100(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Энтальпия воздуха при t2 и VL = 100%, метод enthalpyAir100(): expected = " +
                           enthalpyAir100 + "; actual=" + Math.Round(_ml.enthalpyAir100(), 3));

                Assert.AreEqual(middleTempEnd, Math.Round(_ml.middleTempEnd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Средняя по массе температура материала в конце сушки - middleTempEnd: expected =" +
                            middleTempEnd + "; actual=" + Math.Round(_ml.middleTempEnd(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Средняя по массе температура материала в конце сушки, метод middleTempEnd(): expected = " +
                           middleTempEnd + "; actual=" + Math.Round(_ml.middleTempEnd(), 3));

                Assert.AreEqual(startTempWall, Math.Round(_ml.startTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Температура стенки в начале барабана - startTempWall: expected =" +
                            startTempWall + "; actual=" + Math.Round(_ml.startTempWall(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Температура стенки в начале барабана, метод startTempWall(): expected = " +
                           startTempWall + "; actual=" + Math.Round(_ml.startTempWall(), 3));

                Assert.AreEqual(endTempWall, Math.Round(_ml.endTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Температура стенки в конце барабана - endTempWall: expected =" +
                            endTempWall + "; actual=" + Math.Round(_ml.endTempWall(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Температура стенки в конце барабана, метод endTempWall(): expected = " +
                           endTempWall + "; actual=" + Math.Round(_ml.endTempWall(), 3));

                Assert.AreEqual(middleTempWall, Math.Round(_ml.middleTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Средняя температура металлической стенки барабана - middleTempWall: expected =" +
                            middleTempWall + "; actual=" + Math.Round(_ml.middleTempWall(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Средняя температура металлической стенки барабана, метод middleTempWall(): expected = " +
                           middleTempWall + "; actual=" + Math.Round(_ml.middleTempWall(), 3));

                Assert.AreEqual(alphaHeatTrans, Math.Round(_ml.alphaHeatTrans(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Коэффициент теплоотдачи от поверхности стенки к окрущающей среде - alphaHeatTrans: expected =" +
                            alphaHeatTrans + "; actual=" + Math.Round(_ml.alphaHeatTrans(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, метод alphaHeatTrans(): expected = " +
                           alphaHeatTrans + "; actual=" + Math.Round(_ml.alphaHeatTrans(), 3));

                Assert.AreEqual(startMaterialWet, Math.Round(_ml.startMaterialWet(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Влажность в % от неизменяющейся сухой массы материала в начале сушки - startMaterialWet: expected =" +
                            startMaterialWet + "; actual=" + Math.Round(_ml.startMaterialWet(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Влажность в % от неизменяющейся сухой массы материала в начале сушки, метод startMaterialWet(): expected = " +
                           startMaterialWet + "; actual=" + Math.Round(_ml.startMaterialWet(), 3));

                Assert.AreEqual(endMaterialWet, Math.Round(_ml.endMaterialWet(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Влажность в % от неизменяющейся сухой массы материала в конце сушки -  endMaterialWet: expected =" +
                            endMaterialWet + "; actual=" + Math.Round(_ml.endMaterialWet(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Влажность в % от неизменяющейся сухой массы материала в конце сушки, метод endMaterialWet(): expected = " +
                           endMaterialWet + "; actual=" + Math.Round(_ml.endMaterialWet(), 3));

                Assert.AreEqual(WetEfficiency, Math.Round(_ml.WetEfficiency(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Производительность по испарённой влаге - WetEfficiency: expected =" +
                            WetEfficiency + "; actual=" + Math.Round(_ml.WetEfficiency(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Производительность по испарённой влаге, метод WetEfficiency(): expected = " +
                          WetEfficiency + "; actual=" + Math.Round(_ml.WetEfficiency(), 3));

                Assert.AreEqual(Q2B, Math.Round(_ml.Q2B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q2*B - Q2B: expected =" +
                            Q2B + "; actual=" + Math.Round(_ml.Q2B(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Q2*B, метод Q2B(): expected = " +
                         Q2B + "; actual=" + Math.Round(_ml.Q2B(), 3));

                Assert.AreEqual(Q3B, Math.Round(_ml.Q3B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q3*B - Q3B: expected =" +
                           Q3B + "; actual=" + Math.Round(_ml.Q3B(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Q3*B, метод Q3B(): expected = " +
                         Q3B + "; actual=" + Math.Round(_ml.Q3B(), 3));

                Assert.AreEqual(Q5tpoB, Math.Round(_ml.Q5tpoB(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q5топ*B - Q5tpoB: expected =" +
                           Q5tpoB + "; actual=" + Math.Round(_ml.Q5tpoB(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Q5топ*B, метод Q5tpoB(): expected = " +
                        Q5tpoB + "; actual=" + Math.Round(_ml.Q5tpoB(), 3));

                #endregion 5. Сравнить промежуточные значения из Excel и из библиотеки с заданной точностью

                #region  6. Сравнить итоговые значения из Excel и из библиотеки с заданной точностью

                Assert.AreEqual(Q1, Math.Round(_ml.Q1(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Расход теплоты на прогревание просушиваемых материалов и испарение влаги - Q1: expected =" +
                           Q1 + "; actual=" + Math.Round(_ml.Q1(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Расход теплоты на прогревание просушиваемых материалов и испарение влаги, метод Q1(): expected = " +
                        Q1 + "; actual=" + Math.Round(_ml.Q1(), 3));


                Assert.AreEqual(Q5t, Math.Round(_ml.Q5t(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Потери теплоты вследствие теплопроводности стенок рабочего пространства - Q5t: expected =" +
                           Q5t + "; actual=" + Math.Round(_ml.Q5t(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Потери теплоты вследствие теплопроводности стенок рабочего пространства, метод Q5t(): expected = " +
                        Q5t + "; actual=" + Math.Round(_ml.Q5t(), 3));

                Assert.AreEqual(B, Math.Round(_ml.B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Расход мазута - B: expected =" +
                          B + "; actual=" + Math.Round(_ml.B(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Расход мазута, метод B(): expected = " +
                        B + "; actual=" + Math.Round(_ml.B(), 3));

                Assert.AreEqual(Qh, Math.Round(_ml.Qh(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Тепловая мощность печи - Qh: expected =" +
                         Qh + "; actual=" + Math.Round(_ml.Qh(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Тепловая мощность печи, метод Qh(): expected = " +
                       Qh + "; actual=" + Math.Round(_ml.Qh(), 3));

                Assert.AreEqual(qevapor, Math.Round(_ml.qevapor(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Расход теплоты на 1 кг испаренной влаги - qevapor: expected =" +
                         qevapor + "; actual=" + Math.Round(_ml.qevapor(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Расход теплоты на 1 кг испаренной влаги, метод qevapor(): expected = " +
                      qevapor + "; actual=" + Math.Round(_ml.qevapor(), 3));

                Assert.AreEqual(Q2, Math.Round(_ml.Q2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Потери теплоты с отходящими газами - Q2: expected =" +
                         Q2 + "; actual=" + Math.Round(_ml.Q2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Потери теплоты с отходящими газами, метод Q2(): expected = " +
                      Q2 + "; actual=" + Math.Round(_ml.Q2(), 3));

                Assert.AreEqual(Q3, Math.Round(_ml.Q3(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Потери теплоты с химическим недожогом - Q3: expected =" +
                          Q3 + "; actual=" + Math.Round(_ml.Q3(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Потери теплоты с химическим недожогом, метод Q3(): expected = " +
                      Q3 + "; actual=" + Math.Round(_ml.Q3(), 3));

                Assert.AreEqual(Q5top, Math.Round(_ml.Q5top(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Потери теплоты топкой -  Q5top: expected =" +
                         Q5top + "; actual=" + Math.Round(_ml.Q5top(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Потери теплоты топкой, метод  Q5top(): expected = " +
                     Q5top + "; actual=" + Math.Round(_ml.Q5top(), 3));

                Assert.AreEqual(percentQ1, Math.Round(_ml.percentQ1(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Коэффициент полезного действия печи - percentQ1: expected =" +
                        percentQ1 + "; actual=" + Math.Round(_ml.percentQ1(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("Коэффициент полезного действия печи, метод percentQ1(): expected = " +
                     percentQ1 + "; actual=" + Math.Round(_ml.percentQ1(), 3));

                Assert.AreEqual(percentQ2, Math.Round(_ml.percentQ2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q2 - percentQ2: expected =" +
                        percentQ2 + "; actual=" + Math.Round(_ml.percentQ2(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("%Q2, метод percentQ2(): expected = " +
                     percentQ2 + "; actual=" + Math.Round(_ml.percentQ2(), 3));

                Assert.AreEqual(percentQ3, Math.Round(_ml.percentQ3(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q3 - percentQ3: expected =" +
                        percentQ3 + "; actual=" + Math.Round(_ml.percentQ3(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("%Q3, метод percentQ3(): expected = " +
                     percentQ3 + "; actual=" + Math.Round(_ml.percentQ3(), 3));

                Assert.AreEqual(percentQ5top, Math.Round(_ml.percentQ5top(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q5топ - percentQ5top: expected =" +
                        percentQ5top + "; actual=" + Math.Round(_ml.percentQ5top(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("%Q5топ, метод percentQ5top(): expected = " +
                     percentQ5top + "; actual=" + Math.Round(_ml.percentQ5top(), 3));

                Assert.AreEqual(percentQ5t, Math.Round(_ml.percentQ5t(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q5т -  percentQ5t: expected =" +
                        percentQ5t + "; actual=" + Math.Round(_ml.percentQ5t(), 3));
                // отобразить в журнале тестирования
                Console.WriteLine("");
                Console.WriteLine("--- Результаты Расчёта");
                Console.WriteLine("%Q5т, метод  percentQ5t(): expected = " +
                     percentQ5t + "; actual=" + Math.Round(_ml.percentQ5t(), 3));

                #endregion 6. Сравнить итоговые значения из Excel и из библиотеки с заданной точностью

                //WorkBook.Close(true, null, null);
                //objExcel.Quit();


            }
            catch
            {
            }
            finally
            {

                if (WorkBook != null) WorkBook.Close(false, null, null);
                if (objExcel != null) objExcel.Quit();
               

            }
        }


        [SetUp]
        public void Setup()
        {
        }

    }
}