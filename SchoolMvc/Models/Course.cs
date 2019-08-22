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
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CourseStudent> Students { get; }


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

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content); //Our page returns an OBJECT in our JSON, instead of an array of objects (like when we do GetAll()). Therefore, we must deserialize the Json information as a JObject
            var thisCourse = JsonConvert.DeserializeObject<Course>(jsonResponse.ToString());
            return thisCourse;
        }


        public static void CreateCourse(Course course)
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("courses", Method.POST);
                request.AddJsonBody(course);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await ApiCall.GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

        }
    }

}