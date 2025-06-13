# V6 SQL Explorer DLL

## 🔍 Purpose
This project aims to create a lightweight, embedded SQL explorer tool that runs inside the SoftTech V6 environment. The goal is to provide SQL query, table browsing, and ID tracing functionality using the `V6.Query` COM object without requiring direct database access or external tools like SSMS.

## 🧠 Project Status
🟡 **Current Phase: Project Initiation**

We are currently at ground zero — no Visual Studio solution exists yet. Planning, documentation, and scaffolding are underway.

## 🧱 Planned File Structure

```
V6_SQL_Tool/
├── /src/
│   ├── MainForm.cs
│   ├── SchemaExplorer.cs
│   ├── SqlRunner.cs
│   ├── IDTracer.cs
│   └── Exporter.cs
├── /lib/
│   └── CsvHelper.dll
│   └── ClosedXML.dll
├── V6_SQL_Tool.csproj
├── README.md
├── PROJECT.md
└── PROJECT_LOG.md
```

## ⚙️ Tech Stack

- .NET Framework **4.5.1**
- C# WinForms
- COM interop via `V6.Query`
- CsvHelper for CSV export
- ClosedXML for Excel export

## 🎯 Planned Core Features

| Feature | Status | Notes |
|--------|--------|-------|
| SQL Editor with Execute button | 🔲 Planned | |
| DataGridView to display results | 🔲 Planned | |
| Table browser | 🔲 Planned | Uses `INFORMATION_SCHEMA.TABLES` |
| Column list per table | 🔲 Planned | |
| Global *_ID search | 🔲 Planned | Search all tables for ID value |
| ID → Descr mapping | 🔲 Planned | Smart lookup from code tables |
| CSV / Excel export | 🔲 Planned | CsvHelper / ClosedXML |
| Saved queries | 🔲 Optional | `.json` or `.txt` config |
| Query error handling | 🔲 Optional | Log failed queries |

## 🚧 Next Steps

1. Initialize GitHub repo
2. Create Visual Studio project (WinForms, .NET Framework 4.5.1)
3. Add stubs for `MainForm`, `SqlRunner`, and `V6Interop`
4. Wire up first COM test with `V6.Query`
5. Build basic UI layout
