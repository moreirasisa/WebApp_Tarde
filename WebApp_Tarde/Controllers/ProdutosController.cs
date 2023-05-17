﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.EntityFrameworkCore;
using WebApp_Tarde.Entidades;
using WebApp_Tarde.Models;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }

        public IActionResult Lista()
        {
            return View( db.Produtos.Include(a => a.Categoria).ToList() );
        }

        public IActionResult Cadastro()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.Categorias.ToList();
            return View(model);
        }

        public IActionResult SalvarDados(ProdutoEntidade produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
