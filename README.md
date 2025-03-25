# Identity Test API 🚀

Welcome to the **Identity Test API**! This project is built with **ASP.NET Core** and **Identity** to manage user authentication and authorization, including role-based access control. 🎭

## Features ✨

✅ **User Registration & Login** 🔐
- Users can register with an email and password.
- Secure authentication using **ASP.NET Identity**.
- JWT Token-based Authentication implemented and tested. 🛡️

✅ **Role Management** 🎭
- Create new roles dynamically.
- Assign roles to users.
- Retrieve user roles.

✅ **Security Features** 🔒
- Strong password policies enforced.
- Secure authentication and authorization mechanisms.
- HTTPS support enabled.
- JWT Token Authentication tested successfully. ✅

✅ **API Endpoints** 📡
- User Management
- Role Management
- Authentication

---

## Technologies Used 🛠️
- **ASP.NET Core 9.0** 🏗️
- **Entity Framework Core** 🗄️
- **SQL Server** 🛢️
- **ASP.NET Identity** 🛡️
- **Swagger UI** 📜

---

## Installation & Setup ⚙️

1️⃣ Clone the repository:
```sh
git clone https://github.com/EfsanNart/identity-test-api.git
```

2️⃣ Navigate to the project folder:
```sh
cd identity-test-api
```

3️⃣ Configure your database in `appsettings.json`:
```json
"ConnectionStrings": {
  "Default": "Server=LAPTOP-IOOHI3VQ\\SQLEXPRESS;Database=YOUR_DB;Trusted_Connection=True;"
},
"Jwt": {
  "Key": "your_super_long_secret_key_123456hgfffthfhtfhfhfhfhfhfhfhfhfhtfhyfhtfh!",
  "Issuer": "http://localhost:7044",
  "Audience": "http://localhost:7044"
}
```

4️⃣ Apply migrations and update the database:
```sh
dotnet ef database update
```

5️⃣ Run the application:
```sh
dotnet run
```

6️⃣ Open **Swagger UI** in your browser:
```
http://localhost:5154/swagger
```

---

## API Endpoints 📌

### **User Authentication** 🔐
| Method | Endpoint | Description |
|--------|---------|-------------|
| `POST` | `/api/Accounts/register` | Register a new user |
| `POST` | `/api/Accounts/login` | Authenticate user and login |

### **Role Management** 🎭
| Method | Endpoint | Description |
|--------|---------|-------------|
| `POST` | `/api/Accounts/createrole` | Create a new role |
| `GET` | `/api/Accounts/roles` | Retrieve all roles |
| `POST` | `/api/Accounts/addtorole` | Assign a role to a user |
| `GET` | `/api/Accounts/userroles/{userId}` | Get roles of a user |

### **Protected Test Endpoint 🔒** 
| Method | Endpoint | Description |
|--------|---------|-------------|
| `GET` | `/api/Test/test` | Requires authentication|


---

## Security & Best Practices 🔒
- **Password Policy:** Enforced strong password rules.
- **JWT Authentication:** Implemented and tested successfully.
- **CORS Configuration:** Ensure secure API access.
- **HTTPS Support:** Always run on HTTPS for security.

---

## Contributing 🤝
Feel free to fork, contribute, and submit PRs. Happy coding! 🚀

---

## License 📜
This project is licensed under the **MIT License**.

