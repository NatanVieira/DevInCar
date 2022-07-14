# DevInCar
Projeto Avaliativo I - Módulo II - Dev In House - NDD Tech

O Dev In Car quando é iniciado começa buscando o diretório DevInCar no diretório C:
da máquina do usuário, caso ele não existe o sistema cria.

Caso o diretório exista e existam dentro dele os arquivos veiculos.csv e transferencias.csv,
o sistema carrega as informações contidas neles.

Após esse rápido processo o sistema inicia mostrando o menu inicial para o usuário, ele será
como abaixo:

|============== DEV IN CAR ==============|</br>
| 1 - Cadastro novo veículo              |</br>
| 2 - Vender um veículo                  |</br>
| 3 - Listar veículos                    |</br>
|                                        |</br>
|                                        |</br>
| Pressione qualquer tecla para sair...  |</br>
|========================================|</br>

Caso o usuário escolha a opção número um o seguinte menu é apresentado:

Para cadastrar um novo veículo preencha as informações abaixo:</br>
Tipo de veículo:</br>
1 - Carro</br>
2 - Camionete</br>
3 - Moto / Triciculo</br>
0 - Voltar para o menu inicial</br>


Se o usuário escolher a opção 1, o sistema pedirá informações de nome, cor,
valor, placa, potência, data de fabricação, se é flex ou não e o número de portas.

Se o usuário escolher a opção 2, o sistema pedirá informações de nome, cor,
valor, placa, potência, data de fabricação, se é diesel ou não, número de portas
e capacidade da caçamba.

Se o usuário escolher a opção 3, o sistema pedirá informações de nome, cor,
valor, placa, potência, data de fabricação e número de rodas (para definir
se é uma moto ou triciculo).

Após o cadastro o sistema volta para tela inicial.

Quando o usuário escolhe a opção 2 do menu inicial ele é direcionado
para a venda do veículo, o sistema pede a informação de placa para identificar o
veículo que será vendido, caso o veículo exista o sistema pede o cpf do comprador
e o valor de venda para registrar a transferência e volta para o menu inicial.

Já quando o usuário escolhe a opção de listar veículos o usuário é direcionado para o
menu abaixo:

Escolha o tipo de veículo da listagem:</br>
1 - Carros</br>
2 - Camionetes</br>
3 - Motos/Triciculos</br>
4 - Todos</br>
0 - Voltar para o menu incial</br>


Após a escolha do tipo de veículo o usuário é direcionado para o menu abaixo se referindo
ao tipo de veículo escolhido:

Escolha o tipo de listagem que deseja:</br>
1 - Veículos disponíveis</br>
2 - Veículos vendidos</br>
3 - Veículo vendido com maior valor</br>
4 - Veículo vendido com menor valor</br>
5 - Todos</br>


Então a listagem é apresentada de acordo com o que o usuário deseja.

Quando o usuário sai do sistema, o próprio sistema tenta armazenar as 
informações dentro dos arquivos veiculos.csv e transferencias.csv no
diretório C: da máquina do usuário.
