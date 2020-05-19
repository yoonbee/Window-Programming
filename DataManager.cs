using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp9
{
	class DataManager
	{
		public static List<Seat> Seats = new List<Seat>();
		public static List<Student> Students = new List<Student>();

		static DataManager()
		{
			Load();
		}

		public static void Load()
		{
			try{
				string seatsOutput = File.ReadAllText(@"./Seats.xml");
				XElement seatsXElement = XElement.Parse(seatsOutput);
				Seats = (from item in seatsXElement.Descendants("seat")
							select new Seat()
							{
								SeatNo = int.Parse(item.Element("seatNo").Value),
								IsAvailable = item.Element("isAvailable").Value != "0" ? true : false,
								StdName = item.Element("stdName").Value,
								StdNo = item.Element("stdNo").Value
							}).ToList<Seat>();


				string stdsOutput = File.ReadAllText(@"./Stds.xml");
				XElement stdssXElement = XElement.Parse(stdsOutput);
				Students = (from item in stdssXElement.Descendants("std")
						 select new Student()
						 {
							 StdNo = item.Element("no").Value,
							 StdName = item.Element("name").Value
						 }).ToList<Student>();
			}
			catch (FileLoadException exception)
			{
				// 파일이 없으면 예외 발생: 새로운 파일 생성
				Save();
			}
		}

		public static void Save()
		{
			// 좌석 XML 생성
			string seatsOutput = "";
			seatsOutput += "<seats>\n";
			foreach (var item in Seats)
			{
				seatsOutput += "<seat>\n";
				seatsOutput += "  <seatNo>" + item.SeatNo + "</seatNo>\n";
				seatsOutput += "  <isAvailable>" + (item.IsAvailable? 1:0) + "</isAvailable>\n";
				seatsOutput += "  <stdName>" + item.StdName + "</stdName>\n";
				seatsOutput += "  <stdNo>" + item.StdNo + "</stdNo>\n";
				seatsOutput += "</seat>\n";
			}
			seatsOutput += "</seats>";


			// 학생 XML 생성
			string stdsOutput = "";
			stdsOutput += "<stds>\n";
			foreach (var item in Students)
			{
				stdsOutput += "<std>\n";
				stdsOutput += "  <no>" + item.StdNo + "</no>\n";
				stdsOutput += "  <name>" + item.StdName + "</name>\n";
				stdsOutput += "</std>\n";
			}
			stdsOutput += "</stds>\n";


			// 저장
			File.WriteAllText(@"./Seats.xml", seatsOutput);
			File.WriteAllText(@"./Stds.xml", stdsOutput);
		}
	}
}
