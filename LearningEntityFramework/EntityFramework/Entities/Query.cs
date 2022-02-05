using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Query
    {
        static CRIPTOSEntities
            db = new CRIPTOSEntities();// declaramos la db como static si queremos, es mejor porque asi no abrimos conexiones al the time

        public static List<WALLET> Select()
        {
            //! PARA HACER UN SELECT
            var wallets = (db.WALLET).ToList();// seleccionamos la tabla
            foreach (var oWallet in wallets)// iteramos por todos los objetos de la tabla
            {
                Console.WriteLine(oWallet.ADDRESS);// mostramos un atributo de la tabla
            }
            return wallets;
        }

        public void Insert()
        {
            //! PARA HACER UN INSERT
            // armamos la entidad
            TOKEN DPI = new TOKEN();
            DPI.CONTRACT_ADDRESS = "0x1494ca1f11d487c2bbe4543e90080aeba4ba3c2b";
            DPI.NAME = "Defi Pulse Index";
            DPI.CG_TICKER = "DPI";
            DPI.IS_NATIVE = false;
            DPI.FK_CHAIN = 4;

            // la agregamos a la base de datos
            db.TOKEN.Add(DPI);
            // sincronizamos con la base (IMPORTANTEd)
            db.SaveChanges();
        }

        public static void Where()
        {
            //!  PARA HACER UN WHERE
            // si queremos buscar solamente por KEY_ID:
            TOKEN oTOKEN = db.TOKEN.Find(3);// guarda en oTOKEN
            Console.WriteLine(oTOKEN.NAME);// mostramos lo que queremos

            // si queremos buscar por algun otro atributo
            TOKEN qToken = db.TOKEN.First(d => d.CG_TICKER == "BNB");// trae el primer token cuyo CG_TICKER se llame BNB
            TOKEN zToken = db.TOKEN.Where(d => d.CG_TICKER == "BNB").First();// esta es otra manera, tambien podria traer una coleccion, porque esto me trae solo el primero
        }

        public static void Edit()
        {
            //! PARA HACER UN EDIT
            WALLET_X_TOKEN tempWalletBalancer = db.WALLET_X_TOKEN.First(d => d.FK_WALLET == 1 && d.FK_TOKEN == 3);// levantamos la entidad
            var balanceAnterior = tempWalletBalancer.TOKEN_BALANCE;// si queremos podemos guardar en el back algun dato anterior
            tempWalletBalancer.TOKEN_BALANCE = 2;// editamos

            // guardamos los cambios
            db.Entry(tempWalletBalancer).State = EntityState.Modified;// agregamos esta linea en un edit
            db.SaveChanges();// guardamos
        }

        public static void Delete()
        {
            //! PARA HACER UN DELETE
            TOKEN zTOKEN = db.TOKEN.Find(27);// buscamos la entidad a eliminar
            db.TOKEN.Remove(zTOKEN);// removemos
            db.SaveChanges();// guardamos
        }
        public static IEnumerable<List<CHAIN>> Sp_Chains()
        {
            var temp = db.Database.SqlQuery<List<CHAIN>>("sp_PRUEBA").ToList();
            Console.WriteLine(temp.GetType());
            return temp;
        }
    }
}
