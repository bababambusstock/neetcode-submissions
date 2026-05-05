CREATE TABLE books (
  id INTEGER,
  title TEXT,
  author TEXT
);
-- Do not modify above this line --

-- 1. Befehl: Hinzufügen und Löschen können kombiniert werden
ALTER TABLE books
    ADD COLUMN published_year integer,
    DROP COLUMN author;

-- 2. Befehl: Umbenennen muss separat erfolgen
ALTER TABLE books
    RENAME COLUMN id TO isbn;

-- Do not modify below this line --
SELECT column_name, data_type, column_default
FROM information_schema.columns
WHERE table_name = 'books'
ORDER BY column_name;
