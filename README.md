# Kart_Racing
## Analise dos resultados da corrida de Kart Abaixo

```text
Hora                               Piloto             Nº Volta   Tempo Volta       Velocidade média da volta
23:49:08.277      038 – F.MASSA                           1		1:02.852                        44,275
23:49:10.858      033 – R.BARRICHELLO                     1		1:04.352                        43,243
23:49:11.075      002 – K.RAIKKONEN                       1             1:04.108                        43,408
23:49:12.667      023 – M.WEBBER                          1		1:04.414                        43,202
23:49:30.976      015 – F.ALONSO                          1		1:18.456			35,47
23:50:11.447      038 – F.MASSA                           2		1:03.170                        44,053
23:50:14.860      033 – R.BARRICHELLO                     2		1:04.002                        43,48
23:50:15.057      002 – K.RAIKKONEN                       2             1:03.982                        43,493
23:50:17.472      023 – M.WEBBER                          2		1:04.805                        42,941
23:50:37.987      015 – F.ALONSO                          2		1:07.011			41,528
23:51:14.216      038 – F.MASSA                           3		1:02.769                        44,334
23:51:18.576      033 – R.BARRICHELLO		          3		1:03.716                        43,675
23:51:19.044      002 – K.RAIKKONEN                       3		1:03.987                        43,49
23:51:21.759      023 – M.WEBBER                          3		1:04.287                        43,287
23:51:46.691      015 – F.ALONSO                          3		1:08.704			40,504
23:52:01.796      011 – S.VETTEL                          1		3:31.315			13,169
23:52:17.003      038 – F.MASS                            4		1:02.787                        44,321
23:52:22.586      033 – R.BARRICHELLO		          4		1:04.010                        43,474
23:52:22.120      002 – K.RAIKKONEN                       4		1:03.076                        44,118
23:52:25.975      023 – M.WEBBER                          4		1:04.216                        43,335
23:53:06.741      015 – F.ALONSO                          4		1:20.050			34,763
23:53:39.660      011 – S.VETTEL                          2		1:37.864			28,435
23:54:57.757      011 – S.VETTEL                          3		1:18.097			35,633

```

### Plataforma desenvolda em Asp.Net Core, podendo ser executa direto no iis express do visual studio.

Segue Endpoints e seus resultados esperado, Postman para consulta em anexo.

### Get()
// Busca o resultado informando uma lista com os pilotos e suas posições.
```json
{
    "success": true,
    "data": [
        {
            "posicao": 1,
            "codigoPiloto": 38,
            "nomePiloto": "F.MASSA",
            "qtdVoltas": 4,
            "tempoProva": "00:03:08.7260000"
        },
        {
            "posicao": 2,
            "codigoPiloto": 2,
            "nomePiloto": "K.RAIKKONEN",
            "qtdVoltas": 4,
            "tempoProva": "00:03:11.0450000"
        },
        {
            "posicao": 3,
            "codigoPiloto": 33,
            "nomePiloto": "R.BARRICHELLO",
            "qtdVoltas": 4,
            "tempoProva": "00:03:11.7280000"
        },
        {
            "posicao": 4,
            "codigoPiloto": 23,
            "nomePiloto": "M.WEBBER",
            "qtdVoltas": 4,
            "tempoProva": "00:03:13.3080000"
        },
        {
            "posicao": 5,
            "codigoPiloto": 15,
            "nomePiloto": "F.ALONSO",
            "qtdVoltas": 4,
            "tempoProva": "00:03:35.7650000"
        },
        {
            "posicao": 6,
            "codigoPiloto": 11,
            "nomePiloto": "S.VETTEL",
            "qtdVoltas": 3,
            "tempoProva": "00:02:55.9610000"
        }
    ]
}
```

## Get/FindBestLapAllPilots
// Busca a melhor volta feita por cada piloto.

```json
{
    "success": true,
    "data": [
        {
            "codigoPiloto": 38,
            "nomePiloto": "F.MASSA",
            "melhorVolta": "00:01:02.7690000"
        },
        {
            "codigoPiloto": 33,
            "nomePiloto": "R.BARRICHELLO",
            "melhorVolta": "00:01:03.7160000"
        },
        {
            "codigoPiloto": 2,
            "nomePiloto": "K.RAIKKONEN",
            "melhorVolta": "00:01:03.0760000"
        },
        {
            "codigoPiloto": 23,
            "nomePiloto": "M.WEBBER",
            "melhorVolta": "00:01:04.2160000"
        },
        {
            "codigoPiloto": 15,
            "nomePiloto": "F.ALONSO",
            "melhorVolta": "00:01:07.0110000"
        },
        {
            "codigoPiloto": 11,
            "nomePiloto": "S.VETTEL",
            "melhorVolta": "00:01:18.0970000"
        }
    ]
}
```
## Get/FindBestLap
// Busca a melhor volta feita na corrida

```json
{
    "success": true,
    "data": {
        "codigoPiloto": 38,
        "nomePiloto": "F.MASSA",
        "melhorVolta": "00:01:02.7690000"
    }
}
```

## Get/AverageSpeed
// Calcula e retorna a velocidade média de todos os pilotos durante a corrida.
```json
{
    "success": true,
    "data": [
        {
            "codigoPiloto": 38,
            "nomePiloto": "F.MASSA",
            "velMedia": "44,246"
        },
        {
            "codigoPiloto": 33,
            "nomePiloto": "R.BARRICHELLO",
            "velMedia": "43,468"
        },
        {
            "codigoPiloto": 2,
            "nomePiloto": "K.RAIKKONEN",
            "velMedia": "43,627"
        },
        {
            "codigoPiloto": 23,
            "nomePiloto": "M.WEBBER",
            "velMedia": "43,191"
        },
        {
            "codigoPiloto": 15,
            "nomePiloto": "F.ALONSO",
            "velMedia": "38,066"
        },
        {
            "codigoPiloto": 11,
            "nomePiloto": "S.VETTEL",
            "velMedia": "25,746"
        }
    ]
}
```
