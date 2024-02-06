

Repositorio: https://github.com/joregebadlibre/BP_API.git


{URI} : https://localhost:44326/api/AperturaCuenta

{json} : 

{
    "Cliente":{
        "cedula":"17134400553",
        "nombre":"Jorge",
        "apellidos":"Alvarez",
        "correo":"jr@gmail.com",
        "direccion":"Bangalore",
        "fecha_Registro":"2024-02-05T23:35:47.883",
        "fecha_Actualizacion":"2024-02-05T23:35:47.89"},
     "Cuenta":{
        "tipoCuenta_ID": 1,
        "interes_ID": 1,
        "numero_Cuenta": "12345672289",
        "monto_Apertura": 500,
        "fecha_Apertura": "2024-02-06T00:00:00",
        "fecha_Actualizacion": "2024-02-06T00:00:00"
    }
}

{json response}:
{
    "cliente": {
        "cliente_ID": 13,
        "cedula": "17134400553",
        "nombre": "Jorge",
        "apellidos": "Alvarez",
        "correo": "jr@gmail.com",
        "direccion": "Bangalore",
        "fecha_Registro": "2024-02-05T23:35:47.883",
        "fecha_Actualizacion": "2024-02-05T23:35:47.89"
    },
    "cuenta": {
        "cuenta_ID": 12,
        "cliente_ID": 13,
        "tipoCuenta_ID": 1,
        "interes_ID": 1,
        "numero_Cuenta": "12345672289",
        "monto_Apertura": 500,
        "fecha_Apertura": "2024-02-06T00:00:00",
        "fecha_Actualizacion": "2024-02-06T00:00:00"
    },
    "listareporte": [
        {
            "mes": "2",
            "saldo": 500.36
        },
        {
            "mes": "3",
            "saldo": 500.72
        },
        {
            "mes": "4",
            "saldo": 501.08
        },
        {
            "mes": "5",
            "saldo": 501.44
        },
        {
            "mes": "6",
            "saldo": 501.80
        },
        {
            "mes": "7",
            "saldo": 502.16
        },
        {
            "mes": "8",
            "saldo": 502.52
        },
        {
            "mes": "9",
            "saldo": 502.88
        },
        {
            "mes": "10",
            "saldo": 503.24
        },
        {
            "mes": "11",
            "saldo": 503.60
        },
        {
            "mes": "12",
            "saldo": 503.96
        },
        {
            "mes": "1",
            "saldo": 504.32
        }
    ]
}


