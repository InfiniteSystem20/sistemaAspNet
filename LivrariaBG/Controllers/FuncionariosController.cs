﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaBG.Controllers
{
    public class FuncionariosController : Controller
    {
        // GET: Funcionarios
        public ActionResult Funcionarios()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}