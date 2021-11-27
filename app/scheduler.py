import functools

from flask import (
    Blueprint, flash, g, redirect, render_template, request, session, url_for
)

from app.db import get_db

bp = Blueprint('scheduler', __name__, url_prefix='/')

@bp.route('/', methods=('GET', 'POST'))
def register():
    if request.method == 'GET':