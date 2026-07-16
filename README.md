# Task API

A simple ASP.NET Core Web API for managing tasks using an in-memory list.

## Features

- Get all tasks
- Get task by id
- Create task
- Update task
- Delete task
- Validation
- Swagger documentation

## Run

```bash
dotnet restore
dotnet run
```

Swagger:

```
http://localhost:5052/docs
```

## Endpoints

| Method | Endpoint |
|---------|----------|
| GET | /tasks |
| GET | /tasks/{id} |
| POST | /tasks |
| PUT | /tasks/{id} |
| DELETE | /tasks/{id} |


## Curl Example

```bash
curl -i http://localhost:5052/tasks

HTTP/1.1 200 OK
Content-Type: application/json

[
  {
    Id = 1,
        Title= "study api",
        Done = true
  }
]