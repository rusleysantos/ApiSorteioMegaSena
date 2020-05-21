# ApiSorteioMegaSena
Api sorteia números aleatórios e verifica o prêmio do usuário.

### Uso (Rota: api/CheckResult):
Basta informar quantos numeros deseja sortear em seguida informar os números digitados pelo usuário, veja o exemplo abaixo:
```json
        {
          "quantityNumbers": 6,
          "numbers": 
          [
          	1,
          	15,
          	10,
          	9,
          	13,
          	6
          	]
        }

```
### Retorno de exemplo:
```json
         {
    "status": "Success",
    "messageDev": "",
    "messageUser": "Sorteio Realizado com sucesso!",
    "data": {
        "id": 78,
        "result": "Você não ganhou nada!",
        "numbersHit": [
            13
        ],
        "numbersResult": [
            13,
            59,
            5,
            25,
            45,
            58
        ],
        "numbersUser": [
            1,
            15,
            10,
            9,
            13,
            6
        ],
        "date": "2020-05-20T17:40:21.8960195-03:00"
    }
}

```

### Uso (Rota: api/RandomNumber):
Basta informar quantos numeros deseja sortear na propria rota veja "api/RandomNumber/?quantityNumbers=10"

### Retorno de exemplo:
```json
            [
        53,
        15,
        4,
        34,
        40,
        52,
        24,
        55,
        1,
        13
    ]

```