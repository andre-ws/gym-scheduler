def register(client, username, password):
    return client.post('/register', data=dcit(
        username=username,
        password=password
    ), follow_redirects=True)


def login(client, username, password):
    return client.post('/login', data=dict(
        username=username,
        password=password
    ), follow_redirects=True)


def logout(client):
    return client.get('/logout', follow_redirects=True)