using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataRepository.Entity;
using DataRepository.Context;
using System.Linq;
using System.Collections.Generic;
using DataRepository.Impl;

namespace DataRepository.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public async void TestMethod1()
        {
            BillRepository repo = new BillRepository();
            IList<Bill> bill = await repo.Read();
            foreach(Bill bi in bill)
            {
                foreach(BillDetail detail in bi.Detail)
                {
                    Assert.IsNotNull(detail.Product);
                }
            }
        }
    }
}
