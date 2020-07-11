using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mini_Parduotuve;

namespace Mini_Parduotuve_UnitTest
{
    [TestClass]
    public class ShipmentForm_UnitTest
    {
        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu1360_TikimesGautiDydiS()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 10, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreEqual('S', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu48160_TikimesGautiDydiM()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 400, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreEqual('M', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu96160_TikimesGautiDydiL()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 800, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreEqual('L', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu96160_TikimesKadDydisNebusS()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 800, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('S', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu96160_TikimesKadDydisNebusM()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 800, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('M', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu48160_TikimesKadDydisNebusS()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 400, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('S', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu48160_TikimesKadDydisNebusL()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 400, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('S', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu1360_TikimesKadDydisNebusL()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 10, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('L', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSiuntosDydi_IvesimeKrepselioPrekiuSuBendruTuriu1360_TikimesKadDydisNebusM()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 10, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            Assert.AreNotEqual('M', shipmentForm._Siunta.Siuntos_dydis);
        }

        [TestMethod]
        public void ApskaiciuotiSuma_IvesimeKrepselioPrekiuSuBendraSuma180IrSuDydziuS_TikimesGautiSuma190()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 10, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            shipmentForm.ApskaiciuotiSuma();
            Assert.AreEqual(190, shipmentForm._Siunta.Suma);
        }

        [TestMethod]
        public void ApskaiciuotiSuma_IvesimeKrepselioPrekiuSuBendraSuma4080IrSuDydziuM_TikimesGautiSuma4100()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 400, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            shipmentForm.ApskaiciuotiSuma();
            Assert.AreEqual(4100, shipmentForm._Siunta.Suma);
        }

        [TestMethod]
        public void ApskaiciuotiSuma_IvesimeKrepselioPrekiuSuBendraSuma8080IrSuDydziuL_TikimesGautiSuma8120()
        {
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Veliava", 10, 800, 120));
            DuomenuBaze.Krepselio_Prekes.Add(new Krepselio_preke("Ausines", 8, 10, 16));
            ShipmentForm shipmentForm = new ShipmentForm();
            shipmentForm.ApskaiciuotiSiuntosDydi();
            shipmentForm.ApskaiciuotiSuma();
            Assert.AreEqual(8120, shipmentForm._Siunta.Suma);
        }
    }
}
