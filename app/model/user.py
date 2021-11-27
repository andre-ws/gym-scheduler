class User:
    id: int
    name: str
    password: str

    def __init__(self, id, username, password) -> None:
        self.id = id
        self.username = username
        self.password = password