<script type="text/javascript">
        $(document).ready(function () {
            $('#telefone').mask('(00) 00000-0000');
            $('#cpf').mask('000.000.000-00');

            // Validação de senhas
            $('#formCadastro').submit(function (e) {
                var senha = $('#senha').val();
                var confirmarSenha = $('#confirmarSenha').val();

                if (senha !== confirmarSenha) {
                    e.preventDefault(); // Impede o envio do formulário
                    $('#erroSenha').text('As senhas não coincidem.');
                } else {
                    $('#erroSenha').text(''); // Limpa a mensagem de erro se as senhas coincidirem
                }
            });
        });
    </script>