using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioArbrain.Service.Desfazer;

namespace DesafioArbrain.Service.Desfazer
{
    // Gerencia acões de desfazer em uma tela de aplicação.
    // Permite registrar ações em uma pilha.
    // Desfaz a ultima ação registrada na pilha.
    // Dispara eventos ao registrar e desfazer ações.
    public class DesfazerManager
    {
        private readonly Stack<AcaoDesfazer> _acoesDesfazer;

        public event EventHandler<AcaoDesfazer> AcaoRegistrada;

        public event EventHandler<AcaoDesfazer> AcaoDesfeita;


        public DesfazerManager()
        {
            _acoesDesfazer = new Stack<AcaoDesfazer>();
        }


        public void RegistrarAcao(AcaoDesfazer acao)
        {
            if (acao == null) throw new ArgumentNullException(nameof(acao));
            _acoesDesfazer.Push(acao);
            AcaoRegistrada?.Invoke(this, acao);
        }


        public void DesfazerUltimaAcao()
        {
            if (PodeDesfazer())
            {
                var ultimaAcao = _acoesDesfazer.Pop();
                ultimaAcao.Acao.Invoke();
                AcaoDesfeita?.Invoke(this, ultimaAcao);
            }
            else
            {
                throw new InvalidOperationException("Não há ações para desfazer.");
            }
        }


        public bool PodeDesfazer()
        {
            return _acoesDesfazer.Count > 0;
        }


        public AcaoDesfazer GetUltimaAcao()
        {
            if (PodeDesfazer()) return _acoesDesfazer.Peek();
            else throw new InvalidOperationException("Não há ações para desfazer.");
        }
    }
}
