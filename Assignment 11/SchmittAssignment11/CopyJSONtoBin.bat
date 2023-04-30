@echo off
cd /d %~dp0
copy "contacts.json" "bin/debug/contacts.json"
pause