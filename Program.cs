using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenda {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            //FillBD();
            Run();
        }
        private static void Run() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ListToFile<Client> clientsBD = new ListToFile<Client>("clients.bin", true);
            ListToFile<Flat> flatsBD = new ListToFile<Flat>("flats.bin", true);
            ListToFile<FlatEvaluation> flatsEvaluationsBD = new ListToFile<FlatEvaluation>("flatEvaulations.bin", true);
            ListToFile<Contract> contractsBD = new ListToFile<Contract>("contracts.bin", true);
            ListToFile<Contract> requestsBD = new ListToFile<Contract>("requests.bin", true);
            ListToFile<Client> blockedUsersBD = new ListToFile<Client>("blockedUsers.bin", true);
            ArendaController arendaController = new ArendaController(clientsBD, flatsBD, flatsEvaluationsBD, contractsBD, requestsBD, blockedUsersBD);
            Application.Run(new LoginForm(arendaController));
            clientsBD.Close();
            flatsBD.Close();
            flatsEvaluationsBD.Close();
            contractsBD.Close();
        }
        private static void FillBD() {
            ListToFile<Client> clientsBD = new ListToFile<Client>("clients.bin", true);
            clientsBD.List = new List<Client>() { new Client("Андрей", "Волков", "Сергеевич", new DateTime(1998, 4, 1), new PhoneNumber(79854513654)),
                                                  new Client("Кузнецов", "Никита", "Андреевич", new DateTime(1995, 5, 15), new PhoneNumber(73834533654)) };
            clientsBD.CommitAndClose();


            ListToFile<Flat> flatsBD = new ListToFile<Flat>("flats.bin", true);
            flatsBD.List = new List<Flat>() { new Flat("Добровольского, 37, 55", 25, 3, 14222, "Норм хата"),
                                              new Flat("Беляева, 23, 32", 13, 2, 14333, "Тоже норм хата"),
                                              new Flat("Пацаева, 76, 23", 52, 1, 36555, "А эта уже не норм")};
            flatsBD.CommitAndClose();

            // ListToFile<FlatEvaluation> flatsEvaluationsBD = new ListToFile<FlatEvaluation>("flatEvaulations.bin", true);
            
            
            //ListToFile<Contract> contractsBD = new ListToFile<Contract>("contracts.bin", true);
            //ArendaController arendaController = new ArendaController(clientsBD, flatsBD, flatsEvaluationsBD, contractsBD);




            clientsBD.Close();
            flatsBD.Close();
            //flatsEvaluationsBD.Close();
            //contractsBD.Close();
        }
    }
}
