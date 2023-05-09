# VK-Internship-WebAPI
Необходимо реализовать API приложение на ASP.NET Core.
Требования ббизнес-логики и ограничения:
Формат запроса/ответа - ОЫЩТ
Методы API должны быть асинхронными
В качестве СУБД необходимо использовать PostgreSQL
В качестве ORM необхоидмо использовать EntityFrameworkCore
В качестве моделей данных должны использоваться следующие сущности:
user(id, login, password, created_date, user_group_id, user_state_id)
user_group(id, code, description)
iser_state(id, code, description)