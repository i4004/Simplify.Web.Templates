﻿using System;
using System.Diagnostics;
using MyProject.Api.ViewModels;
using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.Api.Controllers.Api.v1
{
	[Post("/api/v1/sampleIn")]
	public class SampleInController : Controller<SampleModel>
	{
		public override ControllerResponse Invoke()
		{
			try
			{
				Trace.WriteLine($"Object with message received: {Model.Message}");

				return Ajax();
			}
			catch (Exception e)
			{
				return StatusCode(500, e.Message);
			}
		}
	}
}