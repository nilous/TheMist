create table if not exists myuser(
  id SERIAL primary key,
  login varchar(10) unique not null,
  password varchar(20) not null,
  is_admin bool default false,
  is_disabled bool default false
);

create table if not exists mysys(
  name varchar(20) not null,
  item1 varchar(100) not null,
  item2 varchar(100) not null,
  item3 varchar(100) not null
);

create table if not exists item1opt(
  content varchar(100) not null
);

create table if not exists item2opt(
  content varchar(100) not null
);

create table if not exists info(
  id SERIAL primary key,
  user_id int references myuser(id),
  created_at timestamp default current_timestamp,
  item1 varchar(100) not null,
  item2 varchar(100) not null,
  item3 varchar(100) not null
);

insert into myuser(login, password, is_admin) values('admin', 'admin', true);
