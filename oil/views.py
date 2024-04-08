from django.shortcuts import render
from django.core.handlers.asgi import ASGIRequest
from django.http import HttpResponse


def index(request: ASGIRequest):
    return HttpResponse('MexOil')
