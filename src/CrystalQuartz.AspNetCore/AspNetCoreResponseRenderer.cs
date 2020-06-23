﻿using CrystalQuartz.WebFramework.HttpAbstractions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CrystalQuartz.AspNetCore
{
    public class AspNetCoreResponseRenderer : IResponseRenderer
    {
        private readonly HttpContext _context;

        public AspNetCoreResponseRenderer(HttpContext context)
        {
            _context = context;
        }

        public async Task Render(Response response)
        {
            _context.Response.StatusCode = response.StatusCode;
            _context.Response.ContentType = response.ContentType;
            if (response.ContentFiller != null)
            {
                await response.ContentFiller.Invoke(_context.Response.Body);
            }
        }
    }
}