FROM python:3
RUN mkdir /app
WORKDIR /app
ADD . /app
RUN cd /app && pwd && ls
RUN pip install -r requirements.txt
EXPOSE 8000
# CMD ["python", "./manage.py", "runserver"]
