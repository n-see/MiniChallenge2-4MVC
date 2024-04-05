using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge2_4MVC.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class threeQuestions : ControllerBase
    {
        [HttpGet("/AddingSums")]
        public string addSums(double num1, double num2){
                return "The sum of " + num1 + " + " +  num2 + " is " + (num1 + num2);
        }

        [HttpGet("/Sentence")]
        public string sentence(string name, string whatTimeDidYouWakeUp){
            return "Greetings " + name + "! you woke up at " + whatTimeDidYouWakeUp; 

        }
        [HttpGet("/Compare")]
        public string compare(double num1, double num2){
        if(num1 > num2){
            return num1 + " is greater than " + num2;
        } else if(num1 < num2){
            return num2 + " is greater than " + num1;
        }else{
            return num1 + " is the same as " + num2;
        }
        }

    }
}