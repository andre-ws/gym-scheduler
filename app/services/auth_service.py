from werkzeug.security import check_password_hash, generate_password_hash
from repositories.users import UserRepository

class AuthService:
    userRepository = UserRepository()

    def register(self, username, password) -> tuple[str, int]:
        error = None

        if not username:
            error = 'Username is required.'
        elif not password:
            error = 'Password is required.'

        if error is None:
            existing_user = self.userRepository.getUserByName(username)

            hashed_password = generate_password_hash(password)
            self.userRepository.create(username, hashed_password)
            return "", 200
            

        return error, 500


    def login(self, username, password):
        error = None
        db = get_db()
        user = db.execute(
            'SELECT * FROM users WHERE username = ?', (username,)
        ).fetchone()

        if user is None:
            error = 'Incorrect username.'
        elif not check_password_hash(user['password'], password):
            error = 'Incorrect password.'

        if error is None:
            session.clear()
            session['user_id'] = user['id']
            return redirect(url_for('index'))