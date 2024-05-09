using System;

namespace MathLib
{
    public class MathLibrary
    {
        #region Исходные данные
        /// <summary>
        /// Начальная влажность материала, % (Wнач)
        /// </summary> 
        private double _Wstart;    // закрытая переменная класса 
        public double Wstart
        {
            get { return _Wstart; }
            set { _Wstart = value; }
        }

        /// <summary>
        /// Конечная влажность материала, % (Wкон)
        /// </summary> 
        private double _Wend;    // закрытая переменная класса 
        public double Wend
        {
            get { return _Wend; }
            set { _Wend = value; }
        }

        /// <summary>
        /// Содержание углерода в топливе, % (%Ср)
        /// </summary> 
        private double _percentCp;    // закрытая переменная класса 
        public double percentCp
        {
            get { return _percentCp; }
            set { _percentCp = value; }
        }

        /// <summary>
        /// Содержание водорода в топливе, % (%Hр)
        /// </summary> 
        private double _percentHp;    // закрытая переменная класса 
        public double percentHp
        {
            get { return _percentHp; }
            set { _percentHp = value; }
        }

        /// <summary>
        /// Содержание серы в топливе, % (%Sр)
        /// </summary> 
        private double _percentSp;    // закрытая переменная класса 
        public double percentSp
        {
            get { return _percentSp; }
            set { _percentSp = value; }
        }

        /// <summary>
        /// Содержание кислорода в топливе, % (%Oр)
        /// </summary> 
        private double _percentOp;    // закрытая переменная класса 
        public double percentOp
        {
            get { return _percentOp; }
            set { _percentOp = value; }
        }

        /// <summary>
        /// Содержание азота в топливе, % (%Nр)
        /// </summary> 
        private double _percentNp;    // закрытая переменная класса 
        public double percentNp
        {
            get { return _percentNp; }
            set { _percentNp = value; }
        }

        /// <summary>
        /// Содержание золы в топливе, % (%Aр)
        /// </summary> 
        private double _percentAp;    // закрытая переменная класса 
        public double percentAp
        {
            get { return _percentAp; }
            set { _percentAp = value; }
        }

        /// <summary>
        /// Содержание влаги в топливе, % (%Wр)
        /// </summary> 
        private double _percentWp;    // закрытая переменная класса 
        public double percentWp
        {
            get { return _percentWp; }
            set { _percentWp = value; }
        }

        /// <summary>
        /// Максимальная температура газов, градусов цельсия (t1)
        /// </summary> 
        private double _t1;    // закрытая переменная класса 
        public double t1
        {
            get { return _t1; }
            set { _t1 = value; }
        }

        /// <summary>
        /// Минимальная температура газов, градусов цельсия (t2)
        /// </summary> 
        private double _t2;    // закрытая переменная класса 
        public double t2
        {
            get { return _t2; }
            set { _t2 = value; }
        }

        /// <summary>
        /// Коэффициент расхода воздуха (alpha)
        /// </summary> 
        private double _alpha;    // закрытая переменная класса 
        public double alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        /// <summary>
        /// Коэффициент сохранения тепла (eta)
        /// </summary> 
        private double _eta;    // закрытая переменная класса 
        public double eta
        {
            get { return _eta; }
            set { _eta = value; }
        }

        /// <summary>
        /// Температура воздуха, градусов цеьсия (tв)
        /// </summary> 
        private double _tair;    // закрытая переменная класса 
        public double tair
        {
            get { return _tair; }
            set { _tair = value; }
        }

        /// <summary>
        /// Температура газов, градусов цеьсия (tг)
        /// </summary> 
        private double _tgase;    // закрытая переменная класса 
        public double tgase
        {
            get { return _tgase; }
            set { _tgase = value; }
        }

        /// <summary>
        /// Средняя по массе начальная температура материала, градусов цельсия (tм1)
        /// </summary> 
        private double _tm1;    // закрытая переменная класса 
        public double tm1
        {
            get { return _tm1; }
            set { _tm1 = value; }
        }

        /// <summary>
        /// Требуемая производительность, кг/ч (Gт)
        /// </summary> 
        private double _Gt;    // закрытая переменная класса 
        public double Gt
        {
            get { return _Gt; }
            set { _Gt = value; }
        }

        /// <summary>
        /// Процент химического недожога, % (Him)
        /// </summary> 
        private double _Him;    // закрытая переменная класса 
        public double Him
        {
            get { return _Him; }
            set { _Him = value; }
        }

        /// <summary>
        /// Объемное отношение кислорода к азоту в воздухе (k)
        /// </summary> 
        private double _k;    // закрытая переменная класса 
        public double k
        {
            get { return _k; }
            set { _k = value; }
        }

        /// <summary>
        /// Удельная теплоемкость газов, кДж/(кг*К) (cг)
        /// </summary> 
        private double _Cgase;    // закрытая переменная класса 
        public double Cgase
        {
            get { return _Cgase; }
            set { _Cgase = value; }
        }

        /// <summary>
        /// Удельная теплоемкость сухого материала, кДж/(кг*К) (cм)
        /// </summary> 
        private double _Cmaterial;    // закрытая переменная класса 
        public double Cmaterial
        {
            get { return _Cmaterial; }
            set { _Cmaterial = value; }
        }

        /// <summary>
        /// Удельная теплоемкость влаги, кДж/(кг*К) (cвл)
        /// </summary> 
        private double _Cwet;    // закрытая переменная класса 
        public double Cwet
        {
            get { return _Cwet; }
            set { _Cwet = value; }
        }

        /// <summary>
        /// Энтальпия водяного пара при 100 градусах цельсия, кДж/кг (iп100)
        /// </summary> 
        private double _enthalpy100;    // закрытая переменная класса 
        public double enthalpy100
        {
            get { return _enthalpy100; }
            set { _enthalpy100 = value; }
        }

        /// <summary>
        /// Диаметр барабана, м (D)
        /// </summary> 
        private double _D;    // закрытая переменная класса 
        public double D
        {
            get { return _D; }
            set { _D = value; }
        }

        /// <summary>
        /// Длина барабана, м (L)
        /// </summary> 
        private double _L;    // закрытая переменная класса 
        public double L
        {
            get { return _L; }
            set { _L = value; }
        }

        #endregion Исходные данные

        #region Расчетные показатели промежуточных расчетов

        /// <summary>
        /// Удельная теплоемкость воздуха, кДж/(кг*К) (св)
        /// </summary> 
        private double _Cair;    // закрытая переменная класса 
        public double Cair()
        {            
            _Cair = 1.3107*Math.Exp(9*Math.Pow(10.00, -5)*_tair);
            return _Cair;
        }

        /// <summary>
        /// Начальная энтальпия воды, кДж/кг (i1вл)
        /// </summary> 
        private double _enthalpyWater;    // закрытая переменная класса 
        public double enthalpyWater()
        {
            _enthalpyWater = _tair * _Cwet;
            return _enthalpyWater;
        }

        /// <summary>
        /// Удельная теплоемкость пара, кДж/кг (сп)
        /// </summary> 
        private double _Csteam;    // закрытая переменная класса 
        public double Csteam()
        {
            if (t2 >= 200 & t2 <= 300)
            {
                _Csteam = 3 * Math.Pow(10.00, -7) * Math.Pow((_t2 - 100), 3) - 7 * Math.Pow(10.00, -5) * Math.Pow((_t2 - 100), 2) + 0.0077 * (_t2 - 100) + 1.7724;
                return _Csteam;
            }

            else if (t2 >= 300 & t2 < 360)
            {
                _Csteam = 0.8443 * Math.Exp(0.0063 * (_t2 - 100));
                return _Csteam;
            }

            else if (t2 >= 360 & t2 <= 400)
            {
                _Csteam = 0.4868 * Math.Exp(0.0085 * (_t2 - 100));
                return _Csteam;
            }

            else if (t2 > 400 & t2 < 440)
            {
                _Csteam = 0.0394 * Math.Exp(0.0168 * (_t2 - 100));
                return _Csteam;
            }

            else if (t2 >= 440 & t2 <= 450)
            {
                _Csteam = 0.03835 * (_t2 - 100) - 118.19;
                return _Csteam;
            }

            else if (t2 > 450 & t2 <= 460)
            {
                _Csteam = 8 * Math.Pow(10.00, -5) * Math.Exp(0.035 * (_t2 - 100));
                return _Csteam;
            }

            else return _Csteam;
        }

        /// <summary>
        /// Выход CO2 в продуктах горения, м3/кг (V0CO2)
        /// </summary> 
        private double _exitCO2;    // закрытая переменная класса 
        public double exitCO2()
        {
            _exitCO2 = 0.01 * 1.867* _percentCp;
            return _exitCO2;
        }

        /// <summary>
        /// Выход SO2 в продуктах горения, м3/кг (V0SO2)
        /// </summary> 
        private double _exitSO2;    // закрытая переменная класса 
        public double exitSO2()
        {
            _exitSO2 = 0.01 * 0.7 * _percentSp;
            return _exitSO2;
        }

        /// <summary>
        /// Выход H2O в продуктах горения, м3/кг (V0H2O)
        /// </summary> 
        private double _exitH2O;    // закрытая переменная класса 
        public double exitH2O()
        {
            _exitH2O = 0.01 * (11.2* _percentHp+ 1.244* _percentWp);
            return _exitH2O;
        }

        /// <summary>
        /// Расход кислорода на горение, м3/кг (VO2)
        /// </summary> 
        private double _consumptionO2;    // закрытая переменная класса 
        public double consumptionO2()
        {
            _consumptionO2 = 0.01 * (1.867 * _percentCp + 5.6 * _percentHp+ 0.7*(_percentSp- _percentOp)); 
            return _consumptionO2;
        }

        /// <summary>
        /// Выход N2 в продуктах горения, м3/кг (V0N2)
        /// </summary> 
        private double _exitN2;    // закрытая переменная класса 
        public double exitN2()
        {
            _exitN2 = 0.01 * 0.8* _percentNp+ _k* _consumptionO2;
            return _exitN2;
        }

        /// <summary>
        /// Действительный выход N2 в продуктах горения, м3/кг (VaN2)
        /// </summary> 
        private double _realexitN2;    // закрытая переменная класса 
        public double realexitN2()
        {
            _realexitN2 = _exitN2 + _k* (_alpha-1f)* _consumptionO2;
            return _realexitN2;
        }

        /// <summary>
        /// Избыточный объем кислорода, м3/кг (VО2изб)
        /// </summary> 
        private double _overageO2;    // закрытая переменная класса 
        public double overageO2()
        {
            _overageO2 = (_alpha-1) * _consumptionO2;
            return _overageO2;
        }

        /// <summary>
        /// Теоретический расход воздуха, м3/кг (L0)
        /// </summary> 
        private double _theoryСonsAir;    // закрытая переменная класса 
        public double theoryСonsAir()
        {
            _theoryСonsAir = (1+ _k)* _consumptionO2;
            return _theoryСonsAir;
        }

        /// <summary>
        /// Действительный расход сухого воздуха, м3/кг (Lalpha)
        /// </summary> 
        private double _realConsDryAir;    // закрытая переменная класса 
        public double realConsDryAir()
        {
            _realConsDryAir = _alpha * _theoryСonsAir;
            return _realConsDryAir;
        }

        /// <summary>
        /// Выход продуктов горения, м3/кг (Valpha1)
        /// </summary> 
        private double _exitCombusProd;    // закрытая переменная класса 
        public double exitCombusProd()
        {
            _exitCombusProd = _exitCO2+ _exitSO2+ _exitH2O+ _realexitN2+ _overageO2;
            return _exitCombusProd;
        }

        /// <summary>
        /// Теплота сгорания мазута, кДж/кг (Qнр)
        /// </summary> 
        private double _Qfuel;    // закрытая переменная класса 
        public double Qfuel()
        {
            _Qfuel = 340* _percentCp+ 1030* _percentHp- 109*(_percentOp- _percentSp)-25* _percentWp; 
            return _Qfuel;
        }

        /// <summary>
        /// Содержание воздуха в продуктах сгорания, % (VL)
        /// </summary> 
        private double _percentAir;    // закрытая переменная класса 
        public double percentAir()
        {
            _percentAir = 100* (_realConsDryAir - _theoryСonsAir) / _exitCombusProd;
            return _percentAir;
        }

        /// <summary>
        /// Балансовая энтальпия продуктов горения, кДж/м3 (iбобщ)
        /// </summary> 
        private double _balanceEntCombusProd;    // закрытая переменная класса 
        public double balanceEntCombusProd()
        {
            _balanceEntCombusProd = (0.98 * _Qfuel + _realConsDryAir* _tair* _Cair+ _tgase* _Cgase)/ _exitCombusProd;
            return _balanceEntCombusProd;
        }

        /// <summary>
        /// Балансовая температура продуктов горения, градусов цельсия (tab)
        /// </summary> 
        private double _balanceTempCombusProd;    // закрытая переменная класса 
        public double balanceTempCombusProd()
        {
            _balanceTempCombusProd = 1392.3*Math.Log(_balanceEntCombusProd)-9321.8; 
            return _balanceTempCombusProd;
        }

        /// <summary>
        /// Энтальпия факела, кДж/м3 (iф)
        /// </summary> 
        private double _enthalpyTorch;    // закрытая переменная класса 
        public double enthalpyTorch()
        {
            _enthalpyTorch = _balanceEntCombusProd * _eta;
            return _enthalpyTorch;
        }

        /// <summary>
        /// Энтальпия воздуха, кДж/м3 (iв)
        /// </summary> 
        private double _enthalpyAir;    // закрытая переменная класса 
        public double enthalpyAir()
        {
            _enthalpyAir = _tair* _Cair;
            return _enthalpyAir;
        }

        /// <summary>
        /// Энтальпия продуктов сгорания, кДж/м3 (i1)
        /// </summary> 
        private double _enthalpyCombusProd;    // закрытая переменная класса 
        public double enthalpyCombusProd()
        {
            _enthalpyCombusProd = 1.614* _t1- 73.81;
            return _enthalpyCombusProd;
        }

        /// <summary>
        /// Энтальпия дымовых газов, кДж/м3 (i2)
        /// </summary> 
        private double _enthalpyFlueGases;    // закрытая переменная класса 
        public double enthalpyFlueGases()
        {
            _enthalpyFlueGases = 1.614 * _t2 - 73.81;
            return _enthalpyFlueGases;
        }

        /// <summary>
        /// Количество воздуха, м3/м3 (хв)
        /// </summary> 
        private double _airAmount;    // закрытая переменная класса 
        public double airAmount()
        {
            _airAmount = (_enthalpyTorch- _enthalpyCombusProd) /(_enthalpyCombusProd- _enthalpyAir);
            return _airAmount;
        }

        /// <summary>
        /// Энтальпия воздуха при t2 и VL = 100%, кДж/м3 (i2в)
        /// </summary> 
        private double _enthalpyAir100;    // закрытая переменная класса 
        public double enthalpyAir100()
        {
            _enthalpyAir100 = _t2* _Cair;
            return _enthalpyAir100;
        }

        /// <summary>
        /// Средняя по массе температура материала в конце сушки, градусов цельсия (tм2)
        /// </summary> 
        private double _middleTempEnd;    // закрытая переменная класса 
        public double middleTempEnd()
        {
            _middleTempEnd = _t2 - 150;
            return _middleTempEnd;
        }

        /// <summary>
        /// Температура стенки в начале барабана, градусов цельсия (tстнач)
        /// </summary> 
        private double _startTempWall;    // закрытая переменная класса 
        public double startTempWall()
        {
            _startTempWall = (_t1+ _tm1)/2;
            return _startTempWall;
        }

        /// <summary>
        /// Температура стенки в конце барабана, градусов цельсия (tсткон)
        /// </summary> 
        private double _endTempWall;    // закрытая переменная класса 
        public double endTempWall()
        {
            _endTempWall = (_t2 + _middleTempEnd) / 2;
            return _endTempWall;
        }

        /// <summary>
        /// Средняя температура металлической стенки барабана, градусов цельсия (tст)
        /// </summary> 
        private double _middleTempWall;    // закрытая переменная класса 
        public double middleTempWall()
        {
            _middleTempWall = (_startTempWall+ _endTempWall)/2;
            return _middleTempWall;
        }

        /// <summary>
        /// Коэффициент теплоотдачи от поверхности стенки к окрущающей среде, Вт/(м2*К) (alphaв)
        /// </summary> 
        private double _alphaHeatTrans;    // закрытая переменная класса 
        public double alphaHeatTrans()
        {
            _alphaHeatTrans = 8+ 0.06 * _middleTempWall;
            return _alphaHeatTrans;
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в начале сушки, % (W1c)
        /// </summary> 
        private double _startMaterialWet;    // закрытая переменная класса 
        public double startMaterialWet()
        {
            _startMaterialWet = _Wstart/(1-0.01* _Wstart);
            return _startMaterialWet;
        }

        /// <summary>
        /// Влажность в % от неизменяющейся сухой массы материала в конце сушки, % (W2c)
        /// </summary> 
        private double _endMaterialWet;    // закрытая переменная класса 
        public double endMaterialWet()
        {
            _endMaterialWet = _Wend / (1 - 0.01 * _Wend);
            return _endMaterialWet;
        }

        /// <summary>
        /// Производительность по испарённой влаге, кг/ч (Gвл)
        /// </summary> 
        private double _WetEfficiency;    // закрытая переменная класса 
        public double WetEfficiency()
        {
            _WetEfficiency = _Gt*(_startMaterialWet- _endMaterialWet)*0.01;
            return _WetEfficiency;
        }

        /// <summary>
        /// Q2*B, кВт*кг/ч (Q2В)
        /// </summary> 
        private double _Q2B;    // закрытая переменная класса 
        public double Q2B()
        {
            _Q2B = (_enthalpyFlueGases+ _airAmount*(_enthalpyAir100- _enthalpyAir))* _exitCombusProd;
            return _Q2B;
        }

        /// <summary>
        /// Q3*B, кВт*кг/ч (Q3В)
        /// </summary> 
        private double _Q3B;    // закрытая переменная класса 
        public double Q3B()
        {
            _Q3B = _Qfuel* _Him;
            return _Q3B;
        }

        /// <summary>
        /// Q5топ*B, кВт*кг/ч (Q5топВ)
        /// </summary> 
        private double _Q5topB;    // закрытая переменная класса 
        public double Q5tpoB()
        {
            _Q5topB = (1- _eta) * _Qfuel;
            return _Q5topB;
        }

        #endregion  Расчетные показатели промежуточных расчетов

        #region Итоговый расчет

        /// <summary>
        /// Расход теплоты на прогревание просушиваемых материалов и испарение влаги, кВт (Q1)
        /// </summary> 
        private double _Q1;    // закрытая переменная класса 
        public double Q1()
        {
            _Q1 = (_Cmaterial+ 0.01 * _endMaterialWet* _Cwet)*(_middleTempEnd- _tm1) + 0.01* (_startMaterialWet- _endMaterialWet) * (_enthalpy100- _enthalpyWater+ _Csteam* (_t2-100)* _Gt);
            return _Q1;
        }

        /// <summary>
        /// Потери теплоты вследствие теплопроводности стенок рабочего пространства, кВт (Q5т)
        /// </summary> 
        private double _Q5t;    // закрытая переменная класса 
        public double Q5t()
        {
            _Q5t = (0.001* _alphaHeatTrans*(_middleTempWall- _tair)* _D* _L* Math.PI); 
            return _Q5t;
        }

        /// <summary>
        /// Расход мазута, кг/ч (B)
        /// </summary> 
        private double _B;    // закрытая переменная класса 
        public double B()
        {
            _B = (_Q1+ _Q5t) /(_Qfuel- _Q2B- _Q3B- _Q5topB);
            return _B;
        }

        /// <summary>
        /// Тепловая мощность печи, кВт (Qх)
        /// </summary> 
        private double _Qh;    // закрытая переменная класса 
        public double Qh()
        {
            _Qh = _Qfuel* _B;
            return _Qh;
        }

        /// <summary>
        /// Расход теплоты на 1 кг испаренной влаги, кДж/кг (qисп)
        /// </summary> 
        private double _qevapor;    // закрытая переменная класса 
        public double qevapor()
        {
            _qevapor = _Qh / _B;
            return _qevapor;
        }

        /// <summary>
        /// Потери теплоты с отходящими газами, кВт (Q2)
        /// </summary> 
        private double _Q2;    // закрытая переменная класса 
        public double Q2()
        {
            _Q2 = _Q2B* _B;
            return _Q2;
        }

        /// <summary>
        /// Потери теплоты с химическим недожогом, кВт (Q3)
        /// </summary> 
        private double _Q3;    // закрытая переменная класса 
        public double Q3()
        {
            _Q3 = _Q3B * _B;
            return _Q3;
        }

        /// <summary>
        /// Потери теплоты топкой, кВт (Q5топ)
        /// </summary> 
        private double _Q5top;    // закрытая переменная класса 
        public double Q5top()
        {
            _Q5top = _Q5topB * _B;
            return _Q5top;
        }

        /// <summary>
        /// Коэффициент полезного действия печи, % (%Q1)
        /// </summary> 
        private double _percentQ1;    // закрытая переменная класса 
        public double percentQ1()
        {
            _percentQ1 = 100* _Q1/ _Qh;
            return _percentQ1;
        }

        /// <summary>
        /// %Q2, % (%Q2)
        /// </summary> 
        private double _percentQ2;    // закрытая переменная класса 
        public double percentQ2()
        {
            _percentQ2 = 100 * _Q2 / _Qh;
            return _percentQ2;
        }

        /// <summary>
        /// %Q3, % (%Q3)
        /// </summary> 
        private double _percentQ3;    // закрытая переменная класса 
        public double percentQ3()
        {
            _percentQ3 = 100 * _Q3 / _Qh;
            return _percentQ3;
        }

        /// <summary>
        /// %Q5топ, % (%Qтоп)
        /// </summary> 
        private double _percentQ5top;    // закрытая переменная класса 
        public double percentQ5top()
        {
            _percentQ5top = 100 * _Q5top / _Qh;
            return _percentQ5top;
        }

        /// <summary>
        /// %Q5т, % (%Qт)
        /// </summary> 
        private double _percentQ5t;    // закрытая переменная класса 
        public double percentQ5t()
        {
            _percentQ5t = 100 * _Q5t / _Qh;
            return _percentQ5t;
        }

        #endregion Итоговый расчет
    }
}
