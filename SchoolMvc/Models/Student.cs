using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SchoolMvc.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<CourseStudent> Courses { get; }


        public static List<Student> GetAllStudents()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("students", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var allStudents = JsonConvert.DeserializeObject<List<Student>>(jsonResponse.ToString());
            return allStudents;
        }

        public static Student GetThisStudent(int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("students/" + id, Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var thisStudent = JsonConvert.DeserializeObject<Student>(jsonResponse.ToString());
            return thisStudent;
        }

        public static void CreateStudent(Student student)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("students", Method.POST);
                request.AddJsonBody(student);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }

        public static void EditStudent(Student student, int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("students/" + id, Method.PUT);
            request.AddJsonBody(student);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
        }
    }




}