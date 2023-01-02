using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenda {
    public sealed class ArendaController {
        private ListToFile<Client> clientsBD;
        private ListToFile<Flat> flatsBD;
        private ListToFile<FlatEvaluation> flatsEvaluationsBD;
        private ListToFile<Contract> contractsBD;
        private ListToFile<Contract> requestsBD;
        private ListToFile<Client> blockedUsersBD;



        public ArendaController(ListToFile<Client> clientsBD, ListToFile<Flat> flatsBD, ListToFile<FlatEvaluation> flatsEvaluationsBD, ListToFile<Contract> contractsBD, ListToFile<Contract> requestsBD, ListToFile<Client> blockedUsersBD) {
            this.clientsBD = clientsBD;
            this.flatsBD = flatsBD;
            this.flatsEvaluationsBD = flatsEvaluationsBD;
            this.contractsBD = contractsBD;
            this.requestsBD = requestsBD;
            this.blockedUsersBD = blockedUsersBD;
        }

        internal bool IsBlocked(Client client) {
            return blockedUsersBD.List.Contains(client);
        }

        internal void RegisterFlat(Flat flat) {
            flatsBD.List.Add(flat);
            flatsBD.Commit();
        }
        public List<Client> GetClients() {
            return clientsBD.List.ToList();
        }
        public List<Flat> GetFlats() {
            return flatsBD.List.ToList();
        }
        public List<FlatEvaluation> GetFlatsEvaulations(Flat flat) {
            return flatsEvaluationsBD.List.Where(flatEvaulation => flatEvaulation.Flat.Equals(flat)).ToList();
        }
        public void Evaulate(Flat flat, Client client, int evaulate) {
            flatsEvaluationsBD.List.Add(new FlatEvaluation(flat, client, evaulate));
            flatsEvaluationsBD.Commit();
        }
        public List<Contract> GetRequests(Client client) {
            return requestsBD.List.Where(clientRequest => clientRequest.Client.Equals(client)).ToList();
        }
        public List<Contract> GetRequests() {
            return requestsBD.List.ToList();
        }
        public List<Contract> GetContracts() {
            return contractsBD.List.ToList();
        }
        public void AcceptContract(Contract contract) {
            requestsBD.List.Remove(contract);
            contractsBD.List.Add(contract);
            requestsBD.Commit();
            contractsBD.Commit();
        }
        public void TakeRequest(Client client, Flat flat, DateTime start, DateTime end) {
            requestsBD.List.Add(new Contract(client, flat, start, end));
            requestsBD.Commit();
        }
        public void Block(Client client) {
            blockedUsersBD.List.Add(client);
            blockedUsersBD.Commit();
        }

    }
}
