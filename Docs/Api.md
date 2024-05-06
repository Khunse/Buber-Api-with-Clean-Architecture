# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Authentication

### Register
```js
POST {{host}}/auth/register
```


#### Register Request

```json
{
    "firstName" : "Aung",
    "lastName" : "Paing",
    "email" : "aungpaing@gmail.com",
    "password" : "aungaung123"
}
```

#### Register Response
```js
200 OK
```

```json
{
    "id" : "",
    "firstName" : "Aung",
    "lastName" : "Paing",
    "email" : "aungpaing@gmail.com",
    "token" : ""
}
```

### Login
```js
POST {{host}}/auth/login
```


#### Login Request

```json
{
    "email" : "aungpaing@gmail.com",
    "password" : ""
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id"    :   "",
    "firstName" :   "Aung",
    "lastName"  :   "Paing",
    "email" :   "aungpaing@gmail.com",
    "token" :   ""
}
```