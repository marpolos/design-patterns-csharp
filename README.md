# design-patterns
Implementações de exemplos de utilização dos padrões de projeto recomendados

## Métodos criacionais

### Factory Method
- Define a interface para a criação do objeto, mas as subclasses decidem qual classe instanciarão.
- Escopo de classes porque utilizamos as classes para cumprir o que o padrão pede

Na minha implementação estou resolvendo o problema de envio de notificações através de diferentes ferramentas.

Quem é creator/product?
- Product é a notificação em si, a mensagem sendo notificada pela ferramenta. O creator é a classe que chama a implementação da notificação em diferentes meios.

O que é o concrete?
´´E a subsclasse que implementa a classe base.

Por que não seria legal somente utilizar o new?
Porque se eu usasse o new teria baixa coesão e alto acoplamento, pois todo mundo precisaria conhecer as características do meu produto. Dessa forma o produto fica protegido, mas ainda pode existir.
Nessa fábrica precisamos  de muitas classes porque cada comportamento diferente é uma nova implementação.

<img width="1192" height="585" alt="image" src="https://github.com/user-attachments/assets/41adaffc-b0d5-458b-b048-ca0422573e14" />

### Abstract factory
- Escopo de objeto
- Cria interface para criação de famílias de objetos relacionados sem especificar as classes concretas.
- Aqui criaremos uma família de itens dentro de determinado modelo.

<img width="1118" height="567" alt="image" src="https://github.com/user-attachments/assets/72d1ef27-df8a-4f75-9ef5-d1ab5596e64f" />

### Builder
- Criamos variações de um mesmo produto.
- Em vez de termos um construtor que às vezes pode confundir, criamos um builder para criar o objeto.
- Aqui o objeto é sempre novo, ele não pega o que o outro é. Porque é parecido com o Prototype, mas diferencia nesse ponto.
<img width="762" height="414" alt="image" src="https://github.com/user-attachments/assets/308e4155-9d1a-48d9-a908-73e324a9fd49" />

### Prototype
- Criamos clones de um objeto que já existe
- Dependendo de como implementamos o método de clonagem teremos um objeto fazendo referência ao original ou um objeto que copiou e colou e se tornou independente.
- Temos um exemplo interessante nesse caso porque se nossas propriedades são value type, tipos puros, os objetos ficam estáticos, de forma que o shallow copy se comporta muito parecido com o deep copy. A diferença ocorre quando temos objetos aninhados, isto é, complexos.
<img width="949" height="683" alt="image" src="https://github.com/user-attachments/assets/7a68f2a5-2ca0-4da9-8d38-585c23957d59" />



