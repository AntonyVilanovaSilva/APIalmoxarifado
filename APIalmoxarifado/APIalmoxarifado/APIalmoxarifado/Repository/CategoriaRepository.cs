﻿using APIalmoxarifado.Infraestrutura;
using APIalmoxarifado.Models;
using Microsoft.EntityFrameworkCore;

namespace APIalmoxarifado.Repository
{
    public class CategoriaRepository: ICategoriaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Categoria categoria)
        {
            bdConexao.Add(categoria);
            bdConexao.SaveChanges();
        }
        public List<Categoria> GetAll()
        {
            return bdConexao.Categoria.ToList();
        }

        public async Task<bool> DeleteCategoria(int id)
        {
            var e = await bdConexao.Categoria.FirstOrDefaultAsync(x => x.id == id);
            bdConexao.Categoria.Remove(e);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<Categoria> UpdateCategoria(Categoria Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }
    }
}
