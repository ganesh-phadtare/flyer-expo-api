using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flyer_expo_api.Services
{

    public abstract class BaseService : IBaseService
    {
        public abstract void GetDetails();
    }

    public class C1
    {
        string con;
        int numberofI;
        public C1(string conection, int numberOfInstance)
        {
            this.con = conection;
            this.numberofI = numberOfInstance;
        }

        //public void GetDetails()
        //{

        //}
    }

    
        public class C2 : C1
    {
        public C2(string conection, int numberOfInstance, string checkNames) : base(conection, numberOfInstance)
        {

        }

        public virtual void GetDetails()
        {
            C2 c = new C2();
        }
    }

    public abstract class C3 : C2
    {
        public override void GetDetails()
        {
            CreateConnnection();
            base.GetDetails();
        }
    }

    public class C4 : C3
    {
        public override void GetDetails()
        {
            base.GetDetails();
        }
    }
}
