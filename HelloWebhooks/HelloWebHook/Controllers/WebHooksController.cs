﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using HelloWebHook.Models;
using HelloWebHook.Hubs;

namespace HelloWebHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebHooksController : ControllerBase
    {
        private readonly IGithubHookService _githubHookService;

        public WebHooksController(IGithubHookService githubHookService)
        {
            _githubHookService = githubHookService;
        }

        public IActionResult Index()
        {
            return Ok("Hello WebHooksController");
        }

        [GitHubWebHook]
        public IActionResult GitHub(string id, JObject data)
        {
            var val = data.Root.ToObject<RootObject>();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        //[GitHubWebHook]
        ////public async Task<IActionResult> GitHubHandler(string id, string @event, JObject data)
        //public async Task<IActionResult> GitHub(string id, string @event, JObject data)
        //{
        //    var val = data.Root.ToObject<RootObject>();

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    //await _githubHookService.BroadcastMessage(val.issue.html_url);

        //    return Ok();
        //}
    }
}
