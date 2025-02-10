SELECT 'CREATE DATABASE involvemint'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'involvemint')\gexec

<<<<<<< HEAD
SELECT 'CREATE DATABASE "involvemint-e2e"'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'involvemint-e2e')\gexec
=======
SELECT 'CREATE DATABASE involvemint-e2e'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'involvemint-e2e')\gexec

>>>>>>> ddea771773c0c3efe9a694bf9e6b4622887bd774
