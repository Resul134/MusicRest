using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modellib;
using MusicRest.Controllers;

namespace MusicRestTest
{

    [TestClass]
    public class TestMusic
    {
        private RecordsController con = new RecordsController();
        private Record records;

        private static List<Record> recordTestList = new List<Record>()
        {
            new Record("Wow", "wooowoo", 03.40, 1990)
    };


        [TestInitialize]
        public void testGeneral()
        {
            records = new Record("Wow", "wooowoo", 03.40, 1990);


        }


        [TestMethod]
        public void testGetone()
        {
            Record records = con.Get("Wow");
            Assert.AreEqual(records.Title, "Wow");
        }

        [TestMethod]
        public void testGetall()
        {
            List<Record> recordList = con.GetAll();
            Assert.AreEqual(recordList.Count, 2);
        }


        [TestMethod]
        public void testPost()
        {
              //Get all og post

              Record record = new Record("Bla", "Wew", 03.03, 2019);
              con.Post(record);

              Record postedRecord = con.Get("Bla");

              Assert.AreEqual(record.Title, "Bla");






        }


        [TestMethod]
        public void testDelete()
        {
            con.Delete("Bla");


            Record getRecord = con.Get("Bla");

            Assert.AreEqual(records.Title, "Wow");


        }

        [TestMethod]
        public void testPut()
        {
            Record oldRecord = con.Get("Wow");
            oldRecord.Artist = "From";
            con.Put("Wow", oldRecord);
            Record updatedRecord = con.Get("Wow");
            Assert.AreEqual("From", updatedRecord.Artist);
        }
    }

    
}
