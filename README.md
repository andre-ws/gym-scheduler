Configure environment:

Windows / Powershell:
$env:FLASK_APP = "app"
$env:FLASK_ENV = "development"

Linux / Bash:
export FLASK_APP=app
export FLASK_ENV=development

Run:
flask run