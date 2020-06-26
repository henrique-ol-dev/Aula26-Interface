using System;
using System.Collections.Generic;


namespace Aula26_Interface                   
{
    public class Carrinho : ICarrinho
    {       
                                                     
        
        List<Produto> carrinho = new List<Produto>();
        

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(x=>x.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(x=>x.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Adicionar(Produto produto)
        {
           carrinho.Add(produto);
        }
    

        public void Remover (Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Ler()
        {
            foreach(Produto p in carrinho){
                System.Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");
            }
        }
        public void Price(){
            float res=0;
            
            foreach (Produto x in carrinho)
            {
              Console.WriteLine("Somando :{0:c}",x.Preco);
                res+= x.Preco;
            }
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Preço total: {0:c}",res);
            Console.ResetColor();


        }
        
}