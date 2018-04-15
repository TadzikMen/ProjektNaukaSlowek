using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServerApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

		// TODO: Add your service operations here
		[OperationContract]
		bool SprawdzDaneLogowania(string login, string haslo);

		[OperationContract]
		DTO.Logowanie PrzekazDaneDoZalogowania(string login);

		[OperationContract]
		void DodajUzytkownika(string login, string haslo, string email, string imie = null, string nazwisko = null);

		[OperationContract]
		List<DTO.Uwierzytelnianie> PobierzLoginyMaileImiona();

		[OperationContract]
		void WyslijMailaRejestracja(string login, string haslo, string email, string imie = null, string nazwisko = null);

		[OperationContract]
		DTO.FormyNauki RozpocznijNauke(string formaNauki, string jezyk, string poziom);

		[OperationContract]
		DTO.Slowka ZwrocTlumaczenieSlowka(string slowo);

		[OperationContract]
		DTO.Sesja GenerujToken();
	}


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
