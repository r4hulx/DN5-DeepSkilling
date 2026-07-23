# Week 6 — Angular (continued), Git & CI/CD

## StudentApp/
Continuation of the Week 5 Angular hands-on — completes Hands-On 1 through 10 from the
Digital Nurture 5.0 Angular Hands-On Exercise Book: components & binding, directives &
pipes, template-driven and reactive forms, services & DI, routing/guards/lazy loading,
HttpClient + interceptors, NgRx state management, and Karma/Jasmine unit tests.
See `StudentApp/README.md` for setup and a per-hands-on file map.

## GitDemo/
Working artifacts from the 5 Git-HOL labs, produced with real `git` commands (not just
documentation) — init & first commit, `.gitignore` + amend, feature-branch merging,
an actual merge conflict that was created and resolved, and a remote push/PR/branch-cleanup
workflow. Check the repo's commit graph (`git log --oneline --graph`) to see the history.

## CI/CD
`.github/workflows/angular-ci.yml` (repo root) builds and tests `StudentApp` on every
push/PR touching this folder: install → typecheck → Karma unit tests (headless Chrome) →
production build → upload build artifact.

> Note: this workflow file could not be pushed automatically because the GitHub token used
> only had `contents` write access, not `workflow` scope. Add `.github/workflows/angular-ci.yml`
> yourself (content below/in this PR discussion) or re-share a token with the `workflow`
> permission enabled and it can be pushed directly.
