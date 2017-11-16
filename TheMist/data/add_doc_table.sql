create table if not exists mydoc(
  id SERIAL primary key,
  name text unique not null,
  content bytea,
  create_at timestamp default current_timestamp
);
