# Student Course Portal — Digital Nurture 5.0 (DotNet FSE) — Angular Hands-On

Built for the Week 6 Angular hands-on exercises (Hands-On 1–10) of the Digital Nurture 5.0
Deep Skilling program. One Angular application, extended incrementally across all 10 labs.

## Stack
Angular 21 (standalone components), NgRx (Store + Effects), RxJS, Reactive & Template-driven
Forms, HttpClient + interceptors, Karma + Jasmine for unit tests.

## Setup
```bash
npm install
npm install -g json-server   # mock backend
json-server --watch db.json --port 3000   # in one terminal
ng serve                                   # in another
```
App runs at http://localhost:4200, mock API at http://localhost:3000.

## Testing
```bash
npm test
```
Runs the Karma/Jasmine suite in headless Chrome (set `CHROME_BIN` if Chrome isn't on PATH).

## Where each Hands-On lives
| Hands-On | What to look at |
|---|---|
| 1–2 | `pages/home`, `components/header`, lifecycle hooks in `home.ts` |
| 3 | `components/course-card`, `directives/highlight.ts`, `pipes/credit-label-pipe.ts` |
| 4 | `pages/enrollment-form` (template-driven form) |
| 5 | `pages/reactive-enrollment-form` (reactive form, custom + async validators, FormArray) |
| 6 | `services/course.ts`, `services/enrollment.ts`, `services/notification.ts` |
| 7 | `app.routes.ts`, `guards/`, `layout/courses-layout` |
| 8 | `interceptors/`, HTTP calls in `services/course.ts` |
| 9 | `store/course`, `store/enrollment` (NgRx) |
| 10 | `*.spec.ts` files throughout |

## CI/CD
`.github/workflows/ci.yml` runs on every push/PR to `main`: installs deps, typechecks,
runs the unit test suite in headless Chrome, and produces a production build artifact.
