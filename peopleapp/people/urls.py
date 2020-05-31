from django.urls import path

from . import views

urlpatterns = [
    path('', views.people, name='people-index'),
    path('add/', views.add, name='add-person'),
    path('filter', views.filter, name='filter')
]