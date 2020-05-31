from django import forms
from .models import Person

class PersonForm(forms.ModelForm):
    class Meta:
        model = Person
        fields = "__all__"

class FilterForm(forms.Form):
    GENDER_CHOICES = (
    ('MASCHIO', 'maschio'),
    ('FEMMINA', 'femmina'),
    ('ALTRO', 'altro')
    )
    gender = forms.ChoiceField(choices=GENDER_CHOICES)
    age = forms.IntegerField()