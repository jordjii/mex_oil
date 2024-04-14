from django.shortcuts import render
from django.core.handlers.asgi import ASGIRequest
from django.http import HttpResponse
from django.shortcuts import render
from django.shortcuts import render, redirect
from .forms import RegistrationForm
from django.contrib.auth import authenticate, login

def index(request):
    return render(request, 'about.html')

def register(request):
    if request.method == 'POST':
        form = RegistrationForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')
            password = form.cleaned_data.get('password1')
            user = authenticate(username=username, password=password)
            login(request, user)
            return redirect('profile')
    else:
        form = RegistrationForm()
    return render(request, 'register.html', {'form': form})

def profile(request):
    return render(request, 'profile.html')