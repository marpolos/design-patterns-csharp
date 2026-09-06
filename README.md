# design-patterns
Implementações de exemplos de utilização dos padrões de projeto recomendados

Factory Method
- Método criacional
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

