from django.shortcuts import render, redirect, reverse
from django.http import HttpResponse
from .forms import PersonForm, FilterForm
from .models import Person



def index(request):
    return redirect('/people')
def people(request):
    # return HttpResponse("Hello, world. You're at the polls index.")
    return render(request, 'people/index.html')

def add(request):
    if request.method == 'POST':
        form = PersonForm(request.POST)
        if form.is_valid():
            form.save()
        return redirect("/people")
    else:
        form = PersonForm()
        return render(request, 'people/add.html', {"form": form})
    

def filter(request):
    if request.method == "POST":
        form = FilterForm(request.POST)
        if form.is_valid():
            print(form.cleaned_data)
            gender = form.cleaned_data['gender']
            age = form.cleaned_data['age']
            people = Person.objects.filter(age=age, gender=gender)
        return render(request, 'people/list.html', {"form": form, "people": people})
    else:
        form = FilterForm()
        return render(request, 'people/list.html', {"form": form, "people": None})