using NUnit.Framework;
using MathLib;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System;

namespace TestProjectDemo
{
    public class Tests
    {
        private string fileName = "3 ��������� �������.xlsm";
        Excel.Application objExcel = null;
        Excel.Workbook WorkBook = null;

        private object oMissing = System.Reflection.Missing.Value;

        /// <summary>
        /// ����� ������������ �������������� ����������
        /// </summary>
        [Test]
        public void CalculationTest()
        {
            MathLibrary _ml = new MathLibrary();

            #region 1. ��������� �������� ������ 

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

            #endregion 1. ��������� �������� ������

            try
            {
                #region 2. �������� �������� ������ � Excel-����, �������� � ��������������� ������

                objExcel = new Excel.Application();
                WorkBook = objExcel.Workbooks.Open(
                            Directory.GetCurrentDirectory() + "\\" + fileName);
                Excel.Worksheet WorkSheet = (Excel.Worksheet)WorkBook.Sheets["������"];

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

                // ���������� � ������� ������������
                Console.WriteLine("--- �������� ������");
                Console.WriteLine("����� 1: {0}", _ml.Wstart.ToString());
                Console.WriteLine("����� 2: {0}", _ml.Wend.ToString());
                Console.WriteLine("����� 3: {0}", _ml.percentCp.ToString());
                Console.WriteLine("����� 4: {0}", _ml.percentHp.ToString());
                Console.WriteLine("����� 5: {0}", _ml.percentSp.ToString());
                Console.WriteLine("����� 6: {0}", _ml.percentOp.ToString());
                Console.WriteLine("����� 7: {0}", _ml.percentNp.ToString());
                Console.WriteLine("����� 8: {0}", _ml.percentAp.ToString());
                Console.WriteLine("����� 9: {0}", _ml.percentWp.ToString());
                Console.WriteLine("����� 10: {0}", _ml.t1.ToString());
                Console.WriteLine("����� 11: {0}", _ml.t2.ToString());
                Console.WriteLine("����� 12: {0}", _ml.alpha.ToString());
                Console.WriteLine("����� 13: {0}", _ml.eta.ToString());
                Console.WriteLine("����� 14: {0}", _ml.tair.ToString());
                Console.WriteLine("����� 15: {0}", _ml.tgase.ToString());
                Console.WriteLine("����� 16: {0}", _ml.tm1.ToString());
                Console.WriteLine("����� 17: {0}", _ml.Gt.ToString());
                Console.WriteLine("����� 18: {0}", _ml.Him.ToString());
                Console.WriteLine("����� 19: {0}", _ml.k.ToString());
                Console.WriteLine("����� 20: {0}", _ml.Cgase.ToString());
                Console.WriteLine("����� 21: {0}", _ml.Cmaterial.ToString());
                Console.WriteLine("����� 22: {0}", _ml.Cwet.ToString());
                Console.WriteLine("����� 23: {0}", _ml.enthalpy100.ToString());
                Console.WriteLine("����� 24: {0}", _ml.D.ToString());
                Console.WriteLine("����� 25: {0}", _ml.L.ToString());

                #endregion 2. �������� �������� ������ � Excel-����, �������� � ��������������� ������

                #region 3. ��������� �� ������ Excel-����� �������� ������������� ��������� �������

                double Cair = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[26, 2]).Value.ToString());
                double enthalpyWater = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[27, 2]).Value.ToString());
                double Csteam = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[28, 2]).Value.ToString());
                double exitCO2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[40, 2]).Value.ToString());
                double exitSO2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[41, 2]).Value.ToString());
                double exitH2O = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[42, 2]).Value.ToString());
                double consumptionO2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[1, 6]).Value.ToString());
                double exitN2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[43, 2]).Value.ToString());
                double realexitN2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[44, 2]).Value.ToString());
                double overageO2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[45, 2]).Value.ToString());
                double theory�onsAir = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[2, 6]).Value.ToString());
                double realConsDryAir = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[3, 6]).Value.ToString());
                double exitCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[4, 6]).Value.ToString());
                double Qfuel = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[5, 6]).Value.ToString());
                double percentAir = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[6, 6]).Value.ToString());
                double balanceEntCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[7, 6]).Value.ToString());
                double balanceTempCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[8, 6]).Value.ToString());
                double enthalpyTorch = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[9, 6]).Value.ToString());
                double enthalpyAir = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[10, 6]).Value.ToString());
                double enthalpyCombusProd = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[11, 6]).Value.ToString());
                double enthalpyFlueGases = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[12, 6]).Value.ToString());
                double airAmount = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[13, 6]).Value.ToString());
                double enthalpyAir100 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[14, 6]).Value.ToString());
                double middleTempEnd = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[15, 6]).Value.ToString());
                double startTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[33, 6]).Value.ToString());
                double endTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[34, 6]).Value.ToString());
                double middleTempWall = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[32, 6]).Value.ToString());
                double alphaHeatTrans = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[35, 6]).Value.ToString());
                double startMaterialWet = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[38, 6]).Value.ToString());
                double endMaterialWet = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[39, 6]).Value.ToString());
                double WetEfficiency = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[36, 6]).Value.ToString());
                double Q2B = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[26, 6]).Value.ToString());
                double Q3B = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[27, 6]).Value.ToString());
                double Q5tpoB = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[29, 6]).Value.ToString());

                #endregion 3. ��������� �� ������ Excel-����� �������� ������������� ��������� �������

                #region  4. ��������� �� ������ Excel-����� �������� �������� ��������� �������

                double Q1 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[25, 6]).Value.ToString());
                double Q5t = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[30, 6]).Value.ToString());
                double B = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[44, 6]).Value.ToString());
                double Qh = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[46, 6]).Value.ToString());
                double qevapor = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[47, 6]).Value.ToString());
                double Q2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[26, 10]).Value.ToString());
                double Q3 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[27, 10]).Value.ToString());
                double Q5top = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[29, 10]).Value.ToString());
                double percentQ1 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[25, 11]).Value.ToString());
                double percentQ2 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[26, 11]).Value.ToString());
                double percentQ3 = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[27, 11]).Value.ToString());
                double percentQ5top = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[29, 11]).Value.ToString());
                double percentQ5t = double.Parse(((Excel.Range)WorkBook.Sheets["������"].Cells[30, 11]).Value.ToString());

                #endregion  4. ��������� �� ������ Excel-����� �������� �������� ��������� �������

                #region  5. �������� ������������� �������� �� Excel � �� ���������� � �������� ���������

                Assert.AreEqual(Cair, Math.Round(_ml.Cair(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("�������� ������������ ������� - Cair: expected =" +
                            Cair + "; actual=" + Math.Round(_ml.Cair(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("�������� ������������ �������, ����� Cair(): expected = " +
                            Cair + "; actual=" + Math.Round(_ml.Cair(), 3));

                Assert.AreEqual(enthalpyWater, Math.Round(_ml.enthalpyWater(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ��������� ���� - enthalpyWater: expected =" +
                            enthalpyWater + "; actual=" + Math.Round(_ml.enthalpyWater(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� ��������� ����, ����� enthalpyWater(): expected = " +
                            enthalpyWater + "; actual=" + Math.Round(_ml.enthalpyWater(), 3));

                Assert.AreEqual(Csteam, Math.Round(_ml.Csteam(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("�������� ������������ ���� - Csteam: expected =" +
                            Csteam + "; actual=" + Math.Round(_ml.Csteam(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("�������� ������������ ����, ����� Csteam(): expected = " +
                            Csteam + "; actual=" + Math.Round(_ml.Csteam(), 3));

                Assert.AreEqual(exitCO2, Math.Round(_ml.exitCO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����� CO2 � ��������� ������� - SSum: expected =" +
                            exitCO2 + "; actual=" + Math.Round(_ml.exitCO2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����� CO2 � ��������� �������, ����� exitCO2(): expected = " +
                            exitCO2 + "; actual=" + Math.Round(_ml.exitCO2(), 3));

                Assert.AreEqual(exitSO2, Math.Round(_ml.exitSO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����� SO2 � ��������� ������� - exitSO2: expected =" +
                            exitSO2 + "; actual=" + Math.Round(_ml.exitSO2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����� SO2 � ��������� �������, ����� exitSO2(): expected = " +
                            exitSO2 + "; actual=" + Math.Round(_ml.exitSO2(), 3));

                Assert.AreEqual(exitH2O, Math.Round(_ml.exitH2O(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����� H2O � ��������� ������� - exitH2O: expected =" +
                            exitH2O + "; actual=" + Math.Round(_ml.exitH2O(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����� H2O � ��������� �������, ����� exitH2O(): expected = " +
                            exitH2O + "; actual=" + Math.Round(_ml.exitH2O(), 3));

                Assert.AreEqual(consumptionO2, Math.Round(_ml.consumptionO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ��������� �� ������� - consumptionO2: expected =" +
                            consumptionO2 + "; actual=" + Math.Round(_ml.consumptionO2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ��������� �� �������, ����� consumptionO2(): expected = " +
                            consumptionO2 + "; actual=" + Math.Round(_ml.consumptionO2(), 3));

                Assert.AreEqual(exitN2, Math.Round(_ml.exitN2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����� N2 � ��������� ������� - exitN2: expected =" +
                            exitN2 + "; actual=" + Math.Round(_ml.exitN2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����� N2 � ��������� �������, ����� exitN2(): expected = " +
                            exitN2 + "; actual=" + Math.Round(_ml.exitN2(), 3));

                Assert.AreEqual(realexitN2, Math.Round(_ml.realexitN2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("�������������� ����� N2 � ��������� ������� - realexitN2: expected =" +
                            realexitN2 + "; actual=" + Math.Round(_ml.realexitN2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("�������������� ����� N2 � ��������� �������, ����� realexitN2(): expected = " +
                            realexitN2 + "; actual=" + Math.Round(_ml.realexitN2(), 3));

                Assert.AreEqual(overageO2, Math.Round(_ml.overageO2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("���������� ����� ��������� - overageO2: expected =" +
                            overageO2 + "; actual=" + Math.Round(_ml.overageO2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("���������� ����� ���������, ����� overageO2(): expected = " +
                            overageO2 + "; actual=" + Math.Round(_ml.overageO2(), 3));

                Assert.AreEqual(theory�onsAir, Math.Round(_ml.theory�onsAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������������� ������ ������� - theory�onsAir: expected =" +
                            theory�onsAir + "; actual=" + Math.Round(_ml.theory�onsAir(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������������� ������ �������, ����� theory�onsAir(): expected = " +
                            theory�onsAir + "; actual=" + Math.Round(_ml.theory�onsAir(), 3));

                Assert.AreEqual(realConsDryAir, Math.Round(_ml.realConsDryAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("�������������� ������ ������ ������� - realConsDryAir: expected =" +
                            realConsDryAir + "; actual=" + Math.Round(_ml.realConsDryAir(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("�������������� ������ ������ �������, ����� realConsDryAir(): expected = " +
                            realConsDryAir + "; actual=" + Math.Round(_ml.realConsDryAir(), 3));

                Assert.AreEqual(exitCombusProd, Math.Round(_ml.exitCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����� ��������� ������� - exitCombusProd: expected =" +
                            exitCombusProd + "; actual=" + Math.Round(_ml.exitCombusProd(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����� ��������� �������, ����� exitCombusProd(): expected = " +
                            exitCombusProd + "; actual=" + Math.Round(_ml.exitCombusProd(), 3));

                Assert.AreEqual(Qfuel, Math.Round(_ml.Qfuel(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������� �������� ������ - Qfuel: expected =" +
                            Qfuel + "; actual=" + Math.Round(_ml.Qfuel(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������� �������� ������, ����� Qfuel(): expected = " +
                            Qfuel + "; actual=" + Math.Round(_ml.Qfuel(), 3));

                Assert.AreEqual(percentAir, Math.Round(_ml.percentAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("���������� ������� � ��������� �������� - percentAir: expected =" +
                            percentAir + "; actual=" + Math.Round(_ml.percentAir(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("���������� ������� � ��������� ��������, ����� percentAir(): expected = " +
                            percentAir + "; actual=" + Math.Round(_ml.percentAir(), 3));

                Assert.AreEqual(balanceEntCombusProd, Math.Round(_ml.balanceEntCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("���������� ��������� ��������� ������� - balanceEntCombusProd: expected =" +
                            balanceEntCombusProd + "; actual=" + Math.Round(_ml.balanceEntCombusProd(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("���������� ��������� ��������� �������, ����� balanceEntCombusProd(): expected = " +
                            balanceEntCombusProd + "; actual=" + Math.Round(_ml.balanceEntCombusProd(), 3));

                Assert.AreEqual(balanceTempCombusProd, Math.Round(_ml.balanceTempCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("���������� ����������� ��������� ������� - balanceTempCombusProd: expected =" +
                            balanceTempCombusProd + "; actual=" + Math.Round(_ml.balanceTempCombusProd(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("���������� ����������� ��������� �������, ����� balanceTempCombusProd(): expected = " +
                            balanceTempCombusProd + "; actual=" + Math.Round(_ml.balanceTempCombusProd(), 3));

                Assert.AreEqual(enthalpyTorch, Math.Round(_ml.enthalpyTorch(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ������ - enthalpyTorch: expected =" +
                            enthalpyTorch + "; actual=" + Math.Round(_ml.enthalpyTorch(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� ������, ����� enthalpyTorch(): expected = " +
                            enthalpyTorch + "; actual=" + Math.Round(_ml.enthalpyTorch(), 3));

                Assert.AreEqual(enthalpyAir, Math.Round(_ml.enthalpyAir(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ������� - enthalpyAir: expected =" +
                            enthalpyAir + "; actual=" + Math.Round(_ml.enthalpyAir(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� �������, ����� enthalpyAir(): expected = " +
                            enthalpyAir + "; actual=" + Math.Round(_ml.enthalpyAir(), 3));

                Assert.AreEqual(enthalpyCombusProd, Math.Round(_ml.enthalpyCombusProd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ��������� �������� - enthalpyCombusProd: expected =" +
                            enthalpyCombusProd + "; actual=" + Math.Round(_ml.enthalpyCombusProd(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� ��������� ��������, ����� enthalpyCombusProd(): expected = " +
                            enthalpyCombusProd + "; actual=" + Math.Round(_ml.enthalpyCombusProd(), 3));

                Assert.AreEqual(enthalpyFlueGases, Math.Round(_ml.enthalpyFlueGases(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ������� ����� - enthalpyFlueGases: expected =" +
                            enthalpyFlueGases + "; actual=" + Math.Round(_ml.enthalpyFlueGases(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� ������� �����, ����� enthalpyFlueGases(): expected = " +
                            enthalpyFlueGases + "; actual=" + Math.Round(_ml.enthalpyFlueGases(), 3));

                Assert.AreEqual(airAmount, Math.Round(_ml.airAmount(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("���������� ������� - airAmount: expected =" +
                            airAmount + "; actual=" + Math.Round(_ml.airAmount(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("���������� �������, ����� airAmount(): expected = " +
                            airAmount + "; actual=" + Math.Round(_ml.airAmount(), 3));

                Assert.AreEqual(enthalpyAir100, Math.Round(_ml.enthalpyAir100(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� ������� ��� t2 � VL = 100% - enthalpyAir100: expected =" +
                            enthalpyAir100 + "; actual=" + Math.Round(_ml.enthalpyAir100(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� ������� ��� t2 � VL = 100%, ����� enthalpyAir100(): expected = " +
                           enthalpyAir100 + "; actual=" + Math.Round(_ml.enthalpyAir100(), 3));

                Assert.AreEqual(middleTempEnd, Math.Round(_ml.middleTempEnd(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������� �� ����� ����������� ��������� � ����� ����� - middleTempEnd: expected =" +
                            middleTempEnd + "; actual=" + Math.Round(_ml.middleTempEnd(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������� �� ����� ����������� ��������� � ����� �����, ����� middleTempEnd(): expected = " +
                           middleTempEnd + "; actual=" + Math.Round(_ml.middleTempEnd(), 3));

                Assert.AreEqual(startTempWall, Math.Round(_ml.startTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����������� ������ � ������ �������� - startTempWall: expected =" +
                            startTempWall + "; actual=" + Math.Round(_ml.startTempWall(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����������� ������ � ������ ��������, ����� startTempWall(): expected = " +
                           startTempWall + "; actual=" + Math.Round(_ml.startTempWall(), 3));

                Assert.AreEqual(endTempWall, Math.Round(_ml.endTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����������� ������ � ����� �������� - endTempWall: expected =" +
                            endTempWall + "; actual=" + Math.Round(_ml.endTempWall(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����������� ������ � ����� ��������, ����� endTempWall(): expected = " +
                           endTempWall + "; actual=" + Math.Round(_ml.endTempWall(), 3));

                Assert.AreEqual(middleTempWall, Math.Round(_ml.middleTempWall(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������� ����������� ������������� ������ �������� - middleTempWall: expected =" +
                            middleTempWall + "; actual=" + Math.Round(_ml.middleTempWall(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������� ����������� ������������� ������ ��������, ����� middleTempWall(): expected = " +
                           middleTempWall + "; actual=" + Math.Round(_ml.middleTempWall(), 3));

                Assert.AreEqual(alphaHeatTrans, Math.Round(_ml.alphaHeatTrans(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����������� ����������� �� ����������� ������ � ���������� ����� - alphaHeatTrans: expected =" +
                            alphaHeatTrans + "; actual=" + Math.Round(_ml.alphaHeatTrans(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����������� ����������� �� ����������� ������ � ���������� �����, ����� alphaHeatTrans(): expected = " +
                           alphaHeatTrans + "; actual=" + Math.Round(_ml.alphaHeatTrans(), 3));

                Assert.AreEqual(startMaterialWet, Math.Round(_ml.startMaterialWet(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� � % �� �������������� ����� ����� ��������� � ������ ����� - startMaterialWet: expected =" +
                            startMaterialWet + "; actual=" + Math.Round(_ml.startMaterialWet(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� � % �� �������������� ����� ����� ��������� � ������ �����, ����� startMaterialWet(): expected = " +
                           startMaterialWet + "; actual=" + Math.Round(_ml.startMaterialWet(), 3));

                Assert.AreEqual(endMaterialWet, Math.Round(_ml.endMaterialWet(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("��������� � % �� �������������� ����� ����� ��������� � ����� ����� -  endMaterialWet: expected =" +
                            endMaterialWet + "; actual=" + Math.Round(_ml.endMaterialWet(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("��������� � % �� �������������� ����� ����� ��������� � ����� �����, ����� endMaterialWet(): expected = " +
                           endMaterialWet + "; actual=" + Math.Round(_ml.endMaterialWet(), 3));

                Assert.AreEqual(WetEfficiency, Math.Round(_ml.WetEfficiency(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������������������ �� ��������� ����� - WetEfficiency: expected =" +
                            WetEfficiency + "; actual=" + Math.Round(_ml.WetEfficiency(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������������������ �� ��������� �����, ����� WetEfficiency(): expected = " +
                          WetEfficiency + "; actual=" + Math.Round(_ml.WetEfficiency(), 3));

                Assert.AreEqual(Q2B, Math.Round(_ml.Q2B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q2*B - Q2B: expected =" +
                            Q2B + "; actual=" + Math.Round(_ml.Q2B(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("Q2*B, ����� Q2B(): expected = " +
                         Q2B + "; actual=" + Math.Round(_ml.Q2B(), 3));

                Assert.AreEqual(Q3B, Math.Round(_ml.Q3B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q3*B - Q3B: expected =" +
                           Q3B + "; actual=" + Math.Round(_ml.Q3B(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("Q3*B, ����� Q3B(): expected = " +
                         Q3B + "; actual=" + Math.Round(_ml.Q3B(), 3));

                Assert.AreEqual(Q5tpoB, Math.Round(_ml.Q5tpoB(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("Q5���*B - Q5tpoB: expected =" +
                           Q5tpoB + "; actual=" + Math.Round(_ml.Q5tpoB(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("Q5���*B, ����� Q5tpoB(): expected = " +
                        Q5tpoB + "; actual=" + Math.Round(_ml.Q5tpoB(), 3));

                #endregion 5. �������� ������������� �������� �� Excel � �� ���������� � �������� ���������

                #region  6. �������� �������� �������� �� Excel � �� ���������� � �������� ���������

                Assert.AreEqual(Q1, Math.Round(_ml.Q1(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� �� ����������� ������������� ���������� � ��������� ����� - Q1: expected =" +
                           Q1 + "; actual=" + Math.Round(_ml.Q1(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� �� ����������� ������������� ���������� � ��������� �����, ����� Q1(): expected = " +
                        Q1 + "; actual=" + Math.Round(_ml.Q1(), 3));


                Assert.AreEqual(Q5t, Math.Round(_ml.Q5t(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� ���������� ���������������� ������ �������� ������������ - Q5t: expected =" +
                           Q5t + "; actual=" + Math.Round(_ml.Q5t(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� ���������� ���������������� ������ �������� ������������, ����� Q5t(): expected = " +
                        Q5t + "; actual=" + Math.Round(_ml.Q5t(), 3));

                Assert.AreEqual(B, Math.Round(_ml.B(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������ - B: expected =" +
                          B + "; actual=" + Math.Round(_ml.B(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������, ����� B(): expected = " +
                        B + "; actual=" + Math.Round(_ml.B(), 3));

                Assert.AreEqual(Qh, Math.Round(_ml.Qh(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("�������� �������� ���� - Qh: expected =" +
                         Qh + "; actual=" + Math.Round(_ml.Qh(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("�������� �������� ����, ����� Qh(): expected = " +
                       Qh + "; actual=" + Math.Round(_ml.Qh(), 3));

                Assert.AreEqual(qevapor, Math.Round(_ml.qevapor(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� �� 1 �� ���������� ����� - qevapor: expected =" +
                         qevapor + "; actual=" + Math.Round(_ml.qevapor(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� �� 1 �� ���������� �����, ����� qevapor(): expected = " +
                      qevapor + "; actual=" + Math.Round(_ml.qevapor(), 3));

                Assert.AreEqual(Q2, Math.Round(_ml.Q2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� � ���������� ������ - Q2: expected =" +
                         Q2 + "; actual=" + Math.Round(_ml.Q2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� � ���������� ������, ����� Q2(): expected = " +
                      Q2 + "; actual=" + Math.Round(_ml.Q2(), 3));

                Assert.AreEqual(Q3, Math.Round(_ml.Q3(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� � ���������� ��������� - Q3: expected =" +
                          Q3 + "; actual=" + Math.Round(_ml.Q3(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� � ���������� ���������, ����� Q3(): expected = " +
                      Q3 + "; actual=" + Math.Round(_ml.Q3(), 3));

                Assert.AreEqual(Q5top, Math.Round(_ml.Q5top(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("������ ������� ������ -  Q5top: expected =" +
                         Q5top + "; actual=" + Math.Round(_ml.Q5top(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("������ ������� ������, �����  Q5top(): expected = " +
                     Q5top + "; actual=" + Math.Round(_ml.Q5top(), 3));

                Assert.AreEqual(percentQ1, Math.Round(_ml.percentQ1(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("����������� ��������� �������� ���� - percentQ1: expected =" +
                        percentQ1 + "; actual=" + Math.Round(_ml.percentQ1(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("����������� ��������� �������� ����, ����� percentQ1(): expected = " +
                     percentQ1 + "; actual=" + Math.Round(_ml.percentQ1(), 3));

                Assert.AreEqual(percentQ2, Math.Round(_ml.percentQ2(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q2 - percentQ2: expected =" +
                        percentQ2 + "; actual=" + Math.Round(_ml.percentQ2(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("%Q2, ����� percentQ2(): expected = " +
                     percentQ2 + "; actual=" + Math.Round(_ml.percentQ2(), 3));

                Assert.AreEqual(percentQ3, Math.Round(_ml.percentQ3(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q3 - percentQ3: expected =" +
                        percentQ3 + "; actual=" + Math.Round(_ml.percentQ3(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("%Q3, ����� percentQ3(): expected = " +
                     percentQ3 + "; actual=" + Math.Round(_ml.percentQ3(), 3));

                Assert.AreEqual(percentQ5top, Math.Round(_ml.percentQ5top(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q5��� - percentQ5top: expected =" +
                        percentQ5top + "; actual=" + Math.Round(_ml.percentQ5top(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("%Q5���, ����� percentQ5top(): expected = " +
                     percentQ5top + "; actual=" + Math.Round(_ml.percentQ5top(), 3));

                Assert.AreEqual(percentQ5t, Math.Round(_ml.percentQ5t(), 3), 0.001);
                System.Diagnostics.Debug.WriteLine("%Q5� -  percentQ5t: expected =" +
                        percentQ5t + "; actual=" + Math.Round(_ml.percentQ5t(), 3));
                // ���������� � ������� ������������
                Console.WriteLine("");
                Console.WriteLine("--- ���������� �������");
                Console.WriteLine("%Q5�, �����  percentQ5t(): expected = " +
                     percentQ5t + "; actual=" + Math.Round(_ml.percentQ5t(), 3));

                #endregion 6. �������� �������� �������� �� Excel � �� ���������� � �������� ���������

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