﻿using Dominios;
using ModeloDLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaBG.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Cadastrar()
        {

            return View();
        }
        public ActionResult ConsultarTodosClientes()
        {
            var metodoCliente = new ClienteDAO();
            return View(SelecionaCliente(metodoCliente.Select()));
        }
        private List<Cliente> SelecionaCliente(MySqlDataReader retorno)
        {
            var clientes = new List<Cliente>();

            while (retorno.Read())
            {
                var TempCliente = new Cliente()
                {
                    login_id_cli = retorno["login_id_cli"].ToString(),
                    nome_cli = retorno["nome_cli"].ToString(),
                    cpf_cli = retorno["cpf_cli"].ToString(),
                    senha_cli = retorno["senha_cli"].ToString(),
                    telefone_cli = retorno["telefone_cli"].ToString(),
                    email_cli = retorno["email_cli"].ToString(),
                    endereco_cli = retorno["endereco_cli"].ToString(),
                    complemento_cli = retorno["complemento_cli"].ToString(),
                    bairro_cli = retorno["bairro_cli"].ToString(),
                    cidade_cli = retorno["cidade_cli"].ToString(),
                    uf_id_est = retorno["uf_id_est"].ToString(),
                    cep_cli = retorno["cep_cli"].ToString()
                };
                clientes.Add(TempCliente);
            }
            retorno.Close();
            return clientes;
        }

        public ActionResult Consultar()
        {
            var metodoUsuario = new UsuarioDAO();
            return View(SelecionaUsiario(metodoUsuario.Select()));
        }

        private List<Usuario> SelecionaUsiario(MySqlDataReader retorno)
        {
            var usuarios = new List<Usuario>();

            while (retorno.Read())
            {
                var TempUsuario = new Usuario()
                {
                    IdUsu = int.Parse(retorno["IdUsu"].ToString()),
                    NomeUsu = retorno["NomeUsu"].ToString(),
                    Cargo = retorno["Cargo"].ToString(),
                    Senha = retorno["SenhaUsu"].ToString(),
                    DataNasc = DateTime.Parse(retorno["DataNasc"].ToString())
                };
                usuarios.Add(TempUsuario);
            }
            retorno.Close();
            return usuarios;
        }
    }
}