﻿using Microsoft.AspNetCore.Mvc;
using ParkingAPI.Services;

namespace ParkingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    public class ParkingController : Controller
    {
        private ParkingService Service { get; }

        public ParkingController(ParkingService service) => Service = service;

        // GET: api/Parking/NumberOfFreePlaces
        [Route("NumberOfFreePlaces")]
        [HttpGet]
        public int GetNumberOfFreePlaces() => Service.GetNumberOfFreePlaces();

        // GET: api/Parking/NumberOfBusyPlaces
        [Route("NumberOfBusyPlaces")]
        [HttpGet]
        public int GetNumberOfBusyPlaces() => Service.GetNumberOfBusyPlaces();

        //GET: api/Parking/TotalRevenue
        [Route("TotalRevenue")]
        [HttpGet]
        public decimal GetTotalRevenue() => Service.GetTotalRevenue();
    }
}
