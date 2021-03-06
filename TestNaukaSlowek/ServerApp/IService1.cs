﻿using System;
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
		List<DTO.FormyNauki> PobierzFormyNauki(object token);

		[OperationContract]
		DTO.Slowka LosujSlowkoDoFiszki(string jezyk, string poziom, string kategoria, object token);

		[OperationContract]
		DTO.Sesja GenerujToken(string login);

		[OperationContract]
		List<DTO.Slowka> PobierzKategorie(string poziom, object token);

		[OperationContract]
		void AktualizujAktywnoscUzytkownika(object token);

		[OperationContract]
		void WylogujUzytkownika(object token);

		[OperationContract]
		DTO.Rejestracja WyswietlEkranPowitalny(object token);

		[OperationContract]
		List<DTO.Slowka> PobierzWszystkieSlowkaDoSlownika(string jezyk, object token);

		[OperationContract]
		List<DTO.Slowka> WyszukajTlumaczenieSlowka(string szukaneSlowo, object token);

		[OperationContract]
		List<DTO.Slowka> PrzekazDaneDoFiltrowania(object token);

		[OperationContract]
		List<DTO.Slowka> FiltrujPrzezParametry(string jezyk, string poziom, string kategoria, object token);

		[OperationContract]
		List<DTO.Slowka> FiltrujKategorieDoSlownika(string poziom, object token);

		[OperationContract]
		List<DTO.Slowka> PobierzZdaniaDoTlumaczenia(string jezyk, object token);

		[OperationContract]
		void DodajUzytkownikaRecznie(string login, string email, bool czyAdmin, string imie = null, string nazwisko = null);

		[OperationContract]
		void DodajSlowko(string slowko, string tlumaczenie, string jezyk, string kategoria, string poziom);

		[OperationContract]
		List<DTO.Slowka> PrzekazJezykiKategoriePoziomy();

		[OperationContract]
		bool SprawdzCzyUzytkownikJestAdminem(string login);
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
