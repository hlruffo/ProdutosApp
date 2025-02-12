﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(map => map.Id);

            builder.Property(map => map.Preco)
                .HasColumnType("decimal(10,2)");

            builder.HasOne(map => map.Categoria) //Produto TEM 1 Categoria
                .WithMany(map => map.Produto) //Categoria TEM MUITOS Produtos
                .HasForeignKey(map => map.CategoriaId); //Chave estrangeira
        }
    }
}