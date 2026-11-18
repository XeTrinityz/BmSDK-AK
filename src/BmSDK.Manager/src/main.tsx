import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
import "./App.css";
import ErrorBoundary from "./components/ErrorBoundary";

// The browser's right-click menu (Back, Save as, Print...) only belongs in dev. Text fields keep it for copy and paste.
if (!import.meta.env.DEV) {
  document.addEventListener("contextmenu", (e) => {
    const t = e.target as HTMLElement | null;
    if (!t?.closest("input, textarea, [contenteditable='true']")) e.preventDefault();
  });
}

ReactDOM.createRoot(document.getElementById("root") as HTMLElement).render(
  <React.StrictMode>
    <ErrorBoundary>
      <App />
    </ErrorBoundary>
  </React.StrictMode>,
);
