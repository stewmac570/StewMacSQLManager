# V6 SQL Explorer Tool — UI Design Plan

## 🧭 Overview

This document outlines the proposed user interface layout for the V6 SQL Explorer DLL tool. The layout is designed for clarity, productivity, and modular expansion. The UI will be implemented in WinForms and launched inside V6.

---

## 🖼️ Layout Summary

### 🔷 Top Section: Standard Function Button Bar

**Purpose**: Houses main commands for operating the tool.

**Controls**:
- [ Run SQL ]
- [ Export CSV ]
- [ Export Excel ]
- [ Clear Output ]
- [ Trace ID ]
- [ Reload Schema ]

**Implementation**:
- `Panel` docked at `Top`
- Horizontal `Button` controls

---

### 🪟 Main Area: Split Container Layout

The form is split into two vertical columns.

---

### 🗂 Left Column: Navigation / Schema Tools

**Controls**:
- **Table List** — `ListBox` or `TreeView`
- **Column List** — `ListView` (updates on table selection)
- **Search Input** — `TextBox` for filtering column names or *_ID
- **Quick Tools**:
  - Show all *_ID columns
  - Global ID value search

**Implementation**:
- `SplitContainer.Panel1`
- Vertical stack of controls inside a `Panel`

---

### 📋 Right Column: SQL Editor + Results

**Controls**:
- **SQL Editor** — Multi-line `TextBox` (or ScintillaNET for syntax highlighting)
- **Results Grid** — `DataGridView` for query output

**Implementation**:
- `SplitContainer.Panel2`
- SQL editor docked to `Top`, DataGridView docked `Fill` below it

---

## 🛠 Suggested WinForms Structure

```
Form (MainForm)
├── Panel (TopBar) - Dock: Top
│   ├── [ Run SQL ]  [ Export CSV ]  ...
│
├── SplitContainer (MainSplit) - Dock: Fill
│   ├── Panel1 (LeftNav)
│   │   ├── ListBox (Tables)
│   │   ├── ListView (Columns)
│   │   ├── TextBox (Search)
│   │   └── [ Search ID ] button
│   │
│   └── Panel2 (RightMain)
│       ├── TextBox (SQL Editor, multiline)
│       └── DataGridView (Results Grid)
```

---

## ✅ UI Component Mapping

| Section          | WinForms Control       |
|------------------|------------------------|
| Button bar       | `Panel` + `Button`     |
| Table list       | `ListBox` / `TreeView` |
| Column list      | `ListView`             |
| SQL editor       | `TextBox` (Multiline) or `ScintillaNET` |
| Results grid     | `DataGridView`         |
| Layout control   | `SplitContainer`       |

---

## 📌 Notes

- Layout is designed to be expandable without disruption.
- Export logic will use CsvHelper / ClosedXML libraries.
- Table/column info is loaded using `INFORMATION_SCHEMA.TABLES/COLUMNS`.
- Query execution is routed through `V6.Query`.

