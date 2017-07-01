using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.DTO;
using NHibernate;
using COM;

namespace DAL.DAO
{
    public class CustomerDAO
    {
        public static bool Add(Author Customer)
        {
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(Customer);
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        Logger.getInstance().log(e.ToString());
                        return false;
                    }
                }
            }
        }
        public static void Update(Author Customer)
        {
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(Customer);
                    transaction.Commit();
                }
            }
        }

        public static void Remove(Author Customer)
        {
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(Customer);
                    transaction.Commit();
                }
            }
        }

    }
}
