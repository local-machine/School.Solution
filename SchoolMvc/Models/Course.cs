using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SchoolMvc.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static List<Course> GetAllCourses()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("courses", Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var allCourses = JsonConvert.DeserializeObject<List<Course>>(jsonResponse.ToString());
            return allCourses;
        }

        public static Course GetThisCourse(int id)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("courses/" + id, Method.GET);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var thisCourse = JsonConvert.DeserializeObject<Course>(jsonResponse.ToString());
            return thisCourse;
        }
    }




}