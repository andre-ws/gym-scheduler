from app.db import get_db
from model.user import User

users_table = "users"
id_field = "id"
username_field = "username"
password_field = "password"

class UserRepository:
    db = get_db()
    
    def create(self, username, password) -> User:
        user = self.db.execute(
            f"INSERT INTO {users_table} ({username_field}, {password_field}) VALUES (?, ?)",
            (username, password))
            
        self.db.commit()

    def getUserByName(self, username) -> User:
        user = self.db.execute(
            f'SELECT {id_field}, {username_field}, {password_field} FROM {users_table} WHERE {username_field} = ?',
            (username)
        ).fetchone()

        if user:
            return User(user[id_field], user[username_field], user[password_field])
        
        return None